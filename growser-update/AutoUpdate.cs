using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Growser.Update
{
  public class AutoUpdate
  {

    public static async Task<string> CheckAppVersion()
    {
      string url = "https://www.cq-fyy.com/dl/app/VERSION";
      HttpClient client = new HttpClient();
      try
      {
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
        HttpResponseMessage response = await client.SendAsync(request);
        byte[] buff = await response.Content.ReadAsByteArrayAsync();
        return Encoding.UTF8.GetString(buff);
      }
      catch (HttpRequestException ex)
      {
        return "-1";
      }
    }

    public static async Task<string> CheckExeVersion()
    {
      string url = "https://www.cq-fyy.com/dl/msi/VERSION";
      HttpClient client = new HttpClient();
      try
      {
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
        HttpResponseMessage response = await client.SendAsync(request);
        byte[] buff = await response.Content.ReadAsByteArrayAsync();
        return Encoding.UTF8.GetString(buff);
      }
      catch (HttpRequestException ex)
      {
        return "-1";
      }
    }

    public static string Checksum(string filepath)
    {
      if (!File.Exists(filepath))
      {
        return "";
      }
      using (var stream = new BufferedStream(File.OpenRead(filepath), 1024 * 1024))
      {
        SHA256Managed sha = new SHA256Managed();
        byte[] checksum = sha.ComputeHash(stream);
        return BitConverter.ToString(checksum).Replace("-", String.Empty);
      }
    }
  }
}
