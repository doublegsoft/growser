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
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Growser.Update;

namespace Growser.Browser
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static async Task Main(string[] args)
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      // 检查更新
      string remoteVersion = await AutoUpdate.CheckAppVersion();
      if (remoteVersion.Equals("-1"))
      {
        MessageBox.Show("无法连接到更新服务器，请检查网络设置！");
        return;
      }
      remoteVersion = remoteVersion.Replace("\n", "");
      string localVersion = AutoUpdate.Checksum("./www.app");

      if (!remoteVersion.Equals(localVersion))
      {
        Application.Run(new FormDownloading(remoteVersion));
        return;
      }

      if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/his"))
      {
        HISInterfaceProvider.Reload();
      }

      Console.WriteLine(HISInterfaceProvider.Host.GetHospitalId());

      Application.Run(new FormBrowser());
    }
  }
}
