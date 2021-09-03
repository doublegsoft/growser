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
using CefSharp.SchemeHandler;

using Growser.Common.HTTP;
using Growser.Common.JS;
using Growser.Live;
using Growser.Messenger;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using Growser.Update;
using System.Reflection;
using Oracle.ManagedDataAccess.Client;

namespace Growser.Browser
{
  public partial class FormBrowser : Form
  {

    private readonly ChromiumWebBrowser browser;

    private static GrowserObject growserObject = new GrowserObject();

    private static FormMessenger formMessenger; // = new FormMessenger();

    private static FormLoading formLoading = new FormLoading();

    private FormLive formLive;

    public FormBrowser()
    {
      // 初始化CEF环境
      CefSharpSettings.ConcurrentTaskExecution = true;
      CefSharpSettings.FocusedNodeChangedEnabled = true;

      CefSettings settings = new CefSettings();
      settings.CachePath = AppDomain.CurrentDomain.BaseDirectory + "/.cache";
      settings.WindowlessRenderingEnabled = true;
      settings.CefCommandLineArgs.Add("enable-smooth-scrolling", "1");
      settings.CefCommandLineArgs.Add("enable-overlay-scrollbar", "1");
      settings.CefCommandLineArgs.Add("high-dpi-support", "1");
      settings.CefCommandLineArgs.Add("ignore-certificate-errors", "1");
      settings.CefCommandLineArgs.Add("ignore-urlfetcher-cert-requests", "1");
      // settings.CefCommandLineArgs.Add("disable-web-security", "1");
      settings.CefCommandLineArgs.Add("disable-oor-cors", "1");
      settings.CefCommandLineArgs["disable-features"] = "OutOfBlinkCors";

      Cef.Initialize(settings, performDependencyCheck: false, browserProcessHandler: null);

      InitializeComponent();

      browser = new ChromiumWebBrowser("http://localhost")
      {
        RequestHandler = new DecryptedRequestHandler()
      };
      browser.BrowserSettings.UniversalAccessFromFileUrls = CefState.Enabled;
      browser.BrowserSettings.TextAreaResize = CefState.Disabled;
      this.container.ContentPanel.Controls.Add(browser);

      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      browser.LoadingStateChanged += (sender, args) =>
      {
        if (args.IsLoading == false)
        {
          stopwatch.Stop();
          Invoke((MethodInvoker)delegate
          {
            formLoading.Close();
          });
        }
      };

      formLive = new FormLive();

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

      this.Text = "重庆妇幼专科联盟医生工作站";

      string host = growserObject.GetHost();
      if (host == null || host.Length == 0)
      {
        FormSettings formSettings = new FormSettings();
        DialogResult result = formSettings.ShowDialog();
      }
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
        else
        {
          Application.Exit();
        }
      }
    }

    private void toolChat_Click(object sender, EventArgs e)
    {
      formMessenger.Show();
    }

    private void FormBrowser_Load(object sender, EventArgs e)
    {
      formLoading.ShowDialog();
    }

    private void toolPreferences_Click(object sender, EventArgs e)
    {
      FormSettings formSettings = new FormSettings();
      formSettings.ShowDialog();
    }

    private void toolHome_Click(object sender, EventArgs e)
    {
      browser.Reload();
      if (formLoading.IsDisposed)
      {
        formLoading = new FormLoading();
      }
      formLoading.ShowDialog();
    }

    private void toolRemote_Click(object sender, EventArgs e)
    {
      Process.Start(AppDomain.CurrentDomain.BaseDirectory + "/SunloginClient/SunloginClient.exe");
    }

    private void toolVersion_Click(object sender, EventArgs e)
    {

      Process.Start("https://www.cq-fyy.com");
    }

    private async void FormBrowser_Shown(object sender, EventArgs e)
    {
      string localVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
      string remoteVersion = await AutoUpdate.CheckExeVersion();
      if (!localVersion.Equals(remoteVersion))
      {
        toolVersion.Enabled = true;
        toolVersion.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
      }
    }

    private void toolPatient_Click(object sender, EventArgs e)
    {
      string connstr = @"
        Data Source = (
          DESCRIPTION = (
            ADDRESS = (PROTOCOL = TCP)
                      (HOST = 0.0.0.0)
                      (PORT = 1521)
          )(
            CONNECT_DATA = (SERVER = DEDICATED)
                           (SERVICE_NAME = XE)
          )
        );User Id = username;Password=password;
      ";
      OracleConnection conn = new OracleConnection(connstr);
      conn.Open();
      MessageBox.Show("Oracle Version: " + conn.ServerVersion);
      conn.Close();
      conn.Dispose();
    }
  }

 
}
