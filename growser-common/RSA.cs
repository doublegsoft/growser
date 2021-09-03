using Growser.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Growser.Common
{
  static class RSA
  {

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

    public static string DecryptText(byte[] data)
    {
      try
      {

        RSACryptoServiceProvider rsa = PEM.FromPEM(RSA_PRIVATE_KEY).GetRSA();

        int keySize = 2048 / 8;
        byte[] buffer = new byte[keySize];
        using (MemoryStream msInput = new MemoryStream(data))
        {
          using (MemoryStream msOutput = new MemoryStream())
          {
            int readLen;

            while ((readLen = msInput.Read(buffer, 0, keySize)) > 0)
            {
              byte[] dataToDec = new byte[readLen];
              Array.Copy(buffer, 0, dataToDec, 0, readLen);
              byte[] decData = rsa.Decrypt(dataToDec, false);
              msOutput.Write(decData, 0, decData.Length);
            }
            byte[] result = msOutput.ToArray();
            return Encoding.UTF8.GetString(result);
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.StackTrace);
        return "";
      }
    }
  }
}
