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
using CefSharp.WinForms;
using Growser.HTTP;
using Growser.JS;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Growser
{
  public partial class FormBrowser : Form
  {

    private readonly ChromiumWebBrowser browser;

    private static GrowserObject growserObject = new GrowserObject();

    public FormBrowser()
    {

      NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
      foreach (NetworkInterface ni in interfaces)
      {
        Console.WriteLine(ni.NetworkInterfaceType);
        Console.WriteLine(BitConverter.ToString(ni.GetPhysicalAddress().GetAddressBytes()));
      }

      InitializeComponent();

      CefSharpSettings.ConcurrentTaskExecution = true;
      CefSharpSettings.FocusedNodeChangedEnabled = true;

      CefSettings settings = new CefSettings();
      // settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/GPMDP";
      settings.WindowlessRenderingEnabled = true;
      settings.CefCommandLineArgs.Add("enable-smooth-scrolling", "1");
      settings.CefCommandLineArgs.Add("enable-overlay-scrollbar", "1");
      settings.CefCommandLineArgs.Add("high-dpi-support", "1");
      Cef.Initialize(settings);

      browser = new ChromiumWebBrowser("http://localhost")
      {
        RequestHandler = new DecryptedRequestHandler()
      };
      this.Container.ContentPanel.Controls.Add(browser);

      browser.JavascriptObjectRepository.ResolveObject += (sender, e) => 
      {
        var repo = e.ObjectRepository;
        if (e.ObjectName == "growser")
        {
          repo.Register("growser", growserObject, true);
        }
      };

      browser.JavascriptObjectRepository.ObjectBoundInJavascript += (sender, e) =>
      {
        // MessageBox.Show("绑定对象");
      };
    }

    private void toolDebug_Click(object sender, EventArgs e)
    {
      browser.ShowDevTools();
    }

    private void toolExit_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("确定要退出工作站？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
      if (result.Equals(DialogResult.OK))
      {
        Application.Exit();
      }     
    }

    private void FormBrowser_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing)
      {
        DialogResult result = MessageBox.Show("确定要退出工作站？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        if (!result.Equals(DialogResult.OK))
        {
          e.Cancel = true;
        }
      }
    }
  }

 
}
