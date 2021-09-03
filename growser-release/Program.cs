using Growser.Update;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Growser.Release
{
  public class Program
  {

    public static String RSA_PUBLIC_KEY = @"
-----BEGIN PUBLIC KEY-----
MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA8Zn3KLBsxBhuB1ut8O75
s7TwAfejssAYYSLYdScNeRx9L6q5cQwzMgM3h9yPyqzQ5b6WGPtquXmtfOjCCv5t
oej0kx6OzT4smU9emFt5T1hHcC+9XaytXVxpN/dTN07uUi1bi4T62W0tnaG3FnG/
QNHJVdtr/tbB3AywErb848fNbwnLENm82IRNZPyuIGW3W+/BZOR8PzXwDpTT6cYg
nTRgHy7cHbT1c55kQvFNAucjkCCejBqag/WOLrQAjD3Ue7usIgTAFhOycoVrhPse
PEhucNANybxnf7v3PLACx0RI9PMk9y+Ad3RxWjeGjfBlfAKM5Dl4IBUifmneY9VH
MwIDAQAB
-----END PUBLIC KEY-----
";

    public static string RSA_PRIVATE_KEY = @"
-----BEGIN RSA PRIVATE KEY-----
MIIEpQIBAAKCAQEA8Zn3KLBsxBhuB1ut8O75s7TwAfejssAYYSLYdScNeRx9L6q5
cQwzMgM3h9yPyqzQ5b6WGPtquXmtfOjCCv5toej0kx6OzT4smU9emFt5T1hHcC+9
XaytXVxpN/dTN07uUi1bi4T62W0tnaG3FnG/QNHJVdtr/tbB3AywErb848fNbwnL
ENm82IRNZPyuIGW3W+/BZOR8PzXwDpTT6cYgnTRgHy7cHbT1c55kQvFNAucjkCCe
jBqag/WOLrQAjD3Ue7usIgTAFhOycoVrhPsePEhucNANybxnf7v3PLACx0RI9PMk
9y+Ad3RxWjeGjfBlfAKM5Dl4IBUifmneY9VHMwIDAQABAoIBAGuPiUrTKMkwuyOJ
fGoMapzIDCZEEtwMy43LTqTxiv0FYvJqxn5+2PgGGJ3i4x1vTN1LuVVL8Vq7wjIf
CeyNE1AG/4PUEe1sJbznagzYhKx/d+aJSnw+2Tv8XVeuQ50XBeEOEniN7oQIKEvK
aFGUuHnqLAGOW4ksIUiPWYAreXEKcIZGhWzVo9GNF5p0nlzq5SpF5TVvxImTnC+D
DeoXgv3NteWMpKeqM51aQ1ilp8tPLgCC80soHuUi8FgE+WWVF8RXscgGtqA+sy07
PEzsJxnIHMfBOyGZ8l08NY3k5BB/gE/yfhuptlhdFvlis9YtOCzaWH7kgFX0GCrI
KPsHQCECgYEA+zosE1MSqSHbgHTghl+DSlO33wnuKA9PHZQjwK8KcIxExikpJvJ6
K0Wukyz5U0PXqgTHQsuJPUS46PNki9Jjuunk6RFZyCg01yhyjgUwedKGWmKepwuO
N39coo0vsQoz0evwdqrqp62SVQB11xLFPEZKPlfbmZGITtLKxQ1UZYMCgYEA9jD6
kcOhHWO8nGdomKTtmnHtZa6hsdsOMYAAmNbRyfAh59QLZDeIN9maEhxopdltOPzZ
sqq3g2ctgYoN9oGxn0g6v/GqMwyKrMCiM7PjR47e02+TbQSOZ2PtI3rYKBE2C7vM
+Xj06BKCyWNQeN9il5zl5MZ1p106PFz+lsCWmJECgYEAkqFKVmEXNCYxwlD1NxiK
PZiNah2WpkUBLUdocq73jecgwPQHM9c0nQsHsJkAUKv5NR+i2YaIbH0u27ArkDxU
vySC2dGpsFxfMvFFo0S+HWxVxG1pIiBpelTY0XtMSa2lvzFRYUGywflZvkkNfmFT
QzHXZXnMD17UywTXGpoEF1cCgYEAi8qh7PTVXlfMuE6rgMldtW3ta+huHgyRkZ/q
Nt77/ptg1T99PGmf6n6f0prY/Rtpvossnhv72hxTJZQbe5aHIjekTGtPxm7fq1oy
gAMsEezZL9vSLXwB1ElUVOojJRUoyB7aM+nvvnsMUogXIJtPY2GO1ImwMtloAPCZ
C0bN/FECgYEA9Y7Tf9pQ2pQ6sEeHhWONGwms5Tcqcfb8QhCx7+EMDgsG809A6Nb/
UfOCghnviB7rvFlme4DrRYQaqOVE7ZJ1wyWxNiVnsoy+j3MfOrMPWyfJWLAUErjB
Reqf70VH83NIi3aXX2yE5Druf25BbGPvMynHcAL+y6SM/G+Zgy5okxs=
-----END RSA PRIVATE KEY-----";

    static string version;

    static string binary;

    static string release;

    static RSACryptoServiceProvider RSA = PEM.FromPEM(RSA_PUBLIC_KEY).GetRSA();

    [STAThread]
    static void Main()
    {
      version = ConfigurationManager.AppSettings["version"];
      binary = ConfigurationManager.AppSettings["binary"];
      release = ConfigurationManager.AppSettings["release"];

      MakeWWW();

      //EncryptResources();
      //ZipWWW();
      //CopyResources();

      Console.WriteLine("打包程序执行成功，按任意键结束...");
      Console.ReadLine();
    }

    #region
    private static void MakeWWW()
    {
      ///
      /// 拉取最新代码
      /// 
      PullOptions pullOptions = new PullOptions();
      pullOptions.FetchOptions = new FetchOptions
      {
        CredentialsProvider = (url, user, type) => new UsernamePasswordCredentials()
        {
          Username = "christiangann",
          Password = "ganguo800717",
        },
      };

      Repository repo = new Repository(@"juno");
      repo.Reset(ResetMode.Hard, "HEAD");
      Commands.Pull(repo, new Signature("christiangann", "guo.guo.gan@gmail.com", DateTime.Now), pullOptions);
      //Commands.Fetch(repo, "origin", new List<string> { "+refs/heads/master:refs/remotes/origin/master" }, pullOptions.FetchOptions, "");
      //Commands.Checkout(repo, repo.Branches["master"]);
      
      repo.RemoveUntrackedFiles();

      repo = new Repository(@"kui");
      repo.Reset(ResetMode.Hard);
      Commands.Pull(repo, new Signature("christiangann", "guo.guo.gan@gmail.com", DateTime.Now), pullOptions);
      //Commands.Fetch(repo, "origin", new List<string> { "+refs/heads/master:refs/remotes/origin/master" }, pullOptions.FetchOptions, "");
      //Commands.Checkout(repo, repo.Branches["master"]);
      
      repo.RemoveUntrackedFiles();

      ///
      /// 解析首页，拷贝资源
      ///
      string juno = "juno/www";
      string kui3rd = "kui/3rd";
      string kuijs = "kui/src/js";
      string kuicss = "kui/src/css";
      string dest = "www";

      try
      {
        Directory.Delete(dest, true);
      }
      catch (Exception ex)
      {

      }
      

      Dictionary<string, string> dictResources = new Dictionary<string, string>();
      string[] lines = File.ReadAllLines(juno + "/index.html");

      foreach (string line in lines)
      {
        // 忽略注释行
        if (line.Contains("<!--")) continue;
        if (!line.Contains("<script") && !line.Contains("<link")) continue;

        int index = line.IndexOf("src=");
        if (index != -1)
        {
          string ln = line.Substring(index + 5);
          string res = "";
          foreach (char ch in ln.ToCharArray())
          {
            if (ch == '"') break;
            res += ch;
          }
          if (line.Contains("3rd"))
          {
            res = res.Replace("3rd/", "");
            res = res.Substring(0, res.IndexOf("/"));
            var fps = Directory.EnumerateFiles(kui3rd + "/" + res, "*.*", SearchOption.AllDirectories);
            foreach (string fp in fps)
            {
              dictResources[fp.Replace("\\", "/")] = fp;
            }
          }
          else
          {
            dictResources[res] = res;
          }
          continue;
        }

        index = line.IndexOf("href=");
        if (index != -1)
        {
          string ln = line.Substring(index + 6);
          string res = "";
          foreach (char ch in ln.ToCharArray())
          {
            if (ch == '"') break;
            res += ch;
          }
          if (line.Contains("3rd"))
          {
            res = res.Replace("3rd/", "");
            res = res.Substring(0, res.IndexOf("/"));
            var fps = Directory.EnumerateFiles(kui3rd + "/" + res, "*.*", SearchOption.AllDirectories);
            foreach (string fp in fps)
            {
              dictResources[fp.Replace("\\", "/")] = fp;
            }
          }
          else
          {
            dictResources[res] = res;
          }
        }
      }

      /// index.html
      CopyAndEncryptResource(juno + "/index.html", dest + "/index.html");

      /// 3rd
      foreach (string filepath in dictResources.Keys)
      {
        if (!filepath.Contains("3rd")) continue;
        string target = filepath.Replace(kui3rd, dest + "/3rd");
        CopyAndEncryptResource(filepath, target);
      }

      /// img
      var filepaths = Directory.EnumerateFiles(juno + "/img", "*.*", SearchOption.AllDirectories);
      foreach (string filepath in filepaths)
      {
        string target = filepath.Replace(juno, dest);
        CopyAndEncryptResource(filepath, target);
      }

      /// html
      filepaths = Directory.EnumerateFiles(juno + "/html", "*.*", SearchOption.AllDirectories);
      foreach (string filepath in filepaths)
      {
        if (!filepath.EndsWith(".html")) continue;
        string target = filepath.Replace(juno, dest);
        CopyAndEncryptResource(filepath, target);
      }

      /// juno js
      filepaths = Directory.EnumerateFiles(juno + "/js", "*.*", SearchOption.AllDirectories);
      foreach (string filepath in filepaths)
      {
        string fp = filepath.Replace("\\", "/").Replace(juno + "/", "");
        if (!fp.EndsWith(".js") || !dictResources.ContainsKey(fp)) continue;
        string target = filepath.Replace(juno, dest);
        CopyAndEncryptResource(filepath, target);
      }

      /// kui css
      filepaths = Directory.EnumerateFiles(kuicss, "*.*", SearchOption.AllDirectories);
      foreach (string filepath in filepaths)
      {
        string fp = filepath.Replace("\\", "/").Replace(kuicss, "css");
        if (!fp.EndsWith(".css") || !dictResources.ContainsKey(fp)) continue;
        string target = filepath.Replace(kuicss, dest + "/css");
        CopyAndEncryptResource(filepath, target);
      }

      /// kui js
      filepaths = Directory.EnumerateFiles(kuijs, "*.*", SearchOption.AllDirectories);
      foreach (string filepath in filepaths)
      {
        string fp = filepath.Replace("\\", "/").Replace(kuijs, "js/kui");
        if (!fp.EndsWith(".js") || !dictResources.ContainsKey(fp)) continue;
        string target = filepath.Replace(kuijs, dest + "/js/kui");
        CopyAndEncryptResource(filepath, target);
      }

      ///
      /// 压缩打包
      ///
      try
      {
        File.Delete("www.app");
      }
      catch (Exception ex)
      {

      }
      ZipFile.CreateFromDirectory(dest, "www.app");
      StreamWriter writer = File.CreateText("VERSION");
      writer.Write(AutoUpdate.Checksum("www.app"));
      writer.Close();
    }

    #endregion

    #region 拷贝（加密）资源文件
    private static void CopyAndEncryptResource(string source, string target)
    {
      int lastSlashIndex = target.Replace("\\", "/").LastIndexOf("/");
      if (lastSlashIndex != -1)
      {
        string dirpath = target.Substring(0, lastSlashIndex);
        if (!Directory.Exists(dirpath))
        {
          Directory.CreateDirectory(dirpath);
        }
      }
      if (source.EndsWith(".css") || source.EndsWith(".js") || source.EndsWith(".html"))
      {
        var bufferSize = (2048 / 8 - 11);
        byte[] buffer = new byte[bufferSize];

        using (MemoryStream msInput = new MemoryStream(File.ReadAllBytes(source)))
        {
          FileStream output = File.Create(target);
          using (MemoryStream msOutput = new MemoryStream())
          {
            int readLen;
            while ((readLen = msInput.Read(buffer, 0, bufferSize)) > 0)
            {
              byte[] dataToEnc = new byte[readLen];
              Array.Copy(buffer, 0, dataToEnc, 0, readLen);
              byte[] encData = RSA.Encrypt(dataToEnc, false);
              msOutput.Write(encData, 0, encData.Length);
            }

            byte[] result = msOutput.ToArray();
            string ciphertext = Convert.ToBase64String(result);
            byte[] bytes = Encoding.ASCII.GetBytes(ciphertext);
            output.Write(bytes, 0, bytes.Length);
          }
          output.Close();
        }
      } 
      else
      {
        FileStream output = File.Create(target);
        byte[] bytes = File.ReadAllBytes(source);
        output.Write(bytes, 0, bytes.Length);
        output.Close();
      }
    }
    #endregion
  }
}
