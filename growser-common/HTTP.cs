/*
** Copyright (C) doublegsoft.win. All rights reserved.
**
** Redistribution and use in source and binary forms, with or without
** modification, are permitted provided that the following conditions are
** met:
**
**    * Redistributions of source code must retain the above copyright
** notice, this list of conditions and the following disclaimer.
**    * Redistributions in binary form must reproduce the above
** copyright notice, this list of conditions and the following disclaimer
** in the documentation and/or other materials provided with the
** distribution.
**    * Neither the name of Google Inc. nor the names of its
** contributors may be used to endorse or promote products derived from
** this software without specific prior written permission.
**
** THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
** "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
** LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
** A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
** OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
** SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
** LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
** DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
** THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
** (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
** OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
using CefSharp;
using CefSharp.Handler;
using Ionic.Zip;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Growser.Common.HTTP
{

  /// <summary>
  /// 
  /// </summary>
  public class DecryptedRequestHandler : RequestHandler
  {

    protected override IResourceRequestHandler GetResourceRequestHandler(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
    {
      return new DecryptedResourceRequestHandler();
    }

    protected override bool OnSelectClientCertificate(IWebBrowser chromiumWebBrowser, IBrowser browser, bool isProxy, string host, int port, X509Certificate2Collection certificates, ISelectClientCertificateCallback callback)
    {
      return true;
    }

    protected override bool OnCertificateError(IWebBrowser chromiumWebBrowser, IBrowser browser, CefErrorCode errorCode, string requestUrl, ISslInfo sslInfo, IRequestCallback callback)
    {
      Task.Run(() => {
        if (!callback.IsDisposed)
        {
          callback.Continue(true);
        }
      });
      return true;
    }

  }

  /// <summary>
  /// 
  /// </summary>
  public class DecryptedResourceRequestHandler : ResourceRequestHandler, IResponseFilter
  {

    protected override IResponseFilter GetResourceResponseFilter(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IResponse response)
    {
      return this;
    }

    /// <summary>
    /// Gets the decrypted resource handler.
    /// </summary>
    /// <param name="chromiumWebBrowser"></param>
    /// <param name="browser"></param>
    /// <param name="frame"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    protected override IResourceHandler GetResourceHandler(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request)
    {
      if (request.Url.IndexOf("http://localhost") == 0)
      {
        /// it means loading local resources and get decrypted resource handler.
        return new DecryptedResourceHandler();
      }
      else
      {
        /// default resource handler
        return base.GetResourceHandler(chromiumWebBrowser, browser, frame, request);
      }
    }

    void IDisposable.Dispose()
    {

    }

    /// <summary>
    /// Filters the request resources to decrypt the encrypted resources to normal plain text.
    /// </summary>
    /// <param name="dataIn"></param>
    /// <param name="dataInRead"></param>
    /// <param name="dataOut"></param>
    /// <param name="dataOutWritten"></param>
    /// <returns></returns>
    FilterStatus IResponseFilter.Filter(Stream dataIn, out long dataInRead, Stream dataOut, out long dataOutWritten)
    { 
      if (dataIn == null)
      {
        dataInRead = 0;
        dataOutWritten = 0;
        return FilterStatus.Done;
      }
      dataInRead = Math.Min(dataIn.Length, dataOut.Length);
      dataOutWritten = dataInRead;

      var readBytes = new byte[dataInRead];
      dataIn.Read(readBytes, 0, readBytes.Length);
      dataOut.Write(readBytes, 0, readBytes.Length);

      //If we read less than the total amount avaliable then we need
      //return FilterStatus.NeedMoreData so we can then write the rest
      if (dataInRead < dataIn.Length)
      {
        return FilterStatus.NeedMoreData;
      }

      return FilterStatus.Done;
    }

    bool IResponseFilter.InitFilter()
    {
      return true;
    }
  }

  public class DecryptedResourceHandler : ResourceHandler
  {

    static readonly HttpClient client = new HttpClient();

    public override CefReturnValue ProcessRequestAsync(IRequest request, ICallback callback)
    {
      Uri uri = new Uri(request.Url);
      string filepath = uri.AbsolutePath;
      int index = filepath.LastIndexOf(".");
      if (!uri.Host.Equals("localhost")) 
      {
        filepath = request.Url;
      } 
      else if (index == -1)
      {
        this.MimeType = "text/html";
      }
      else
      {
        this.MimeType = GetMimeType(filepath.Substring(index));
      }

      Task.Run(() =>
      {
        using (callback)
        {
          ZipFile wwwapp = ZipFile.Read("www.app");
          wwwapp.ParallelDeflateThreshold = -1;

          Stream stream = null;
          if (string.Equals(filepath, "/", StringComparison.OrdinalIgnoreCase))
          {
            filepath = "index.html";
          }
          //
          // remove leading slash
          //
          if (filepath.IndexOf("/") == 0)
          {
            filepath = filepath.Substring(1);
          }
          try
          {
            if (filepath.EndsWith(".css") || filepath.EndsWith(".html") || filepath.EndsWith(".js"))
            {
              if (wwwapp[filepath] != null)
              {
                MemoryStream entryStream = new MemoryStream();
                wwwapp[filepath].Extract(entryStream);
                entryStream.Seek(0, SeekOrigin.Begin);

                string plaintext = RSA.DecryptText(Convert.FromBase64String(new StreamReader(entryStream).ReadToEnd()));
                entryStream.Close();
                stream = new MemoryStream(Encoding.UTF8.GetBytes(plaintext));
              }
            }
            else
            {
              if (wwwapp[filepath] != null)
              {
                MemoryStream entryStream = new MemoryStream();
                wwwapp[filepath].Extract(entryStream);
                entryStream.Seek(0, SeekOrigin.Begin);
                stream = entryStream;
              }
            }
          }
          catch (Exception ex)
          {
            Console.WriteLine(ex.StackTrace);
          }
          if (stream == null)
          {
            callback.Cancel();
          }
          else
          {
            //Reset the stream position to 0 so the stream can be copied into the underlying unmanaged buffer
            stream.Position = 0;
            //Populate the response values - No longer need to implement GetResponseHeaders (unless you need to perform a redirect)
            ResponseLength = stream.Length;
            StatusCode = (int)HttpStatusCode.OK;
            Stream = stream;
            callback.Continue();
          }
        }
      });
      return CefReturnValue.ContinueAsync;
    }

    public override void Dispose()
    {
      if (this.Stream != null)
      {
        this.Stream.Close();
      }
    }
  }

}
