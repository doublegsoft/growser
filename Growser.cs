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
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Growser
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
      // frame.LoadUrl(request.Url);
      return new DecryptedResourceHandler();
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
    public override CefReturnValue ProcessRequestAsync(IRequest request, ICallback callback)
    {
      Uri uri = new Uri(request.Url);
      string filepath = uri.AbsolutePath;
      int index = filepath.LastIndexOf(".");
      if (index == -1)
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
          Stream stream = null;

          if (string.Equals(filepath, "/PostDataTest.html", StringComparison.OrdinalIgnoreCase))
          {
            var postDataElement = request.PostData.Elements.FirstOrDefault();
            stream = ResourceHandler.GetMemoryStream("Post Data: " + (postDataElement == null ? "null" : postDataElement.GetBody()), Encoding.UTF8);
          }

          if (string.Equals(filepath, "/PostDataAjaxTest.html", StringComparison.OrdinalIgnoreCase))
          {
            var postData = request.PostData;
            if (postData == null)
            {
              stream = ResourceHandler.GetMemoryStream("Post Data: null", Encoding.UTF8);
            }
            else
            {
              var postDataElement = postData.Elements.FirstOrDefault();
              stream = ResourceHandler.GetMemoryStream("Post Data: " + (postDataElement == null ? "null" : postDataElement.GetBody()), Encoding.UTF8);
            }
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
            MimeType = "text/html";
            StatusCode = (int)HttpStatusCode.OK;
            Stream = stream;

            callback.Continue();
          }
        }
      });

      return CefReturnValue.ContinueAsync;
    }
  }

}
