using CefSharp;
using CefSharp.WinForms;
using Growser.Common.HTTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Growser.Messenger
{
  public partial class FormMessenger : Form
  {

    private readonly ChromiumWebBrowser browser;

    private bool isMouseDown = false;

    private Point formLocation;

    private Point mouseOffset;

    public FormMessenger()
    {
      InitializeComponent();

      CefSharpSettings.ConcurrentTaskExecution = true;
      CefSharpSettings.FocusedNodeChangedEnabled = true;

      CefSettings settings = new CefSettings();
      // settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/GPMDP";
      settings.WindowlessRenderingEnabled = true;
      settings.CefCommandLineArgs.Add("enable-smooth-scrolling", "1");
      settings.CefCommandLineArgs.Add("enable-overlay-scrollbar", "1");
      settings.CefCommandLineArgs.Add("high-dpi-support", "1");
      if (!Cef.IsInitialized)
      {
        // Cef.Initialize(settings);
      }

      browser = new ChromiumWebBrowser("http://localhost/html/stdbiz-ex/im/index.html")
      {
        RequestHandler = new DecryptedRequestHandler()
      };
      this.container.ContentPanel.Controls.Add(browser);
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void panelControl_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.isMouseDown = true;
        this.formLocation = this.Location;
        this.mouseOffset = Control.MousePosition;
      }
    }

    private void panelControl_MouseMove(object sender, MouseEventArgs e)
    {
      if (this.isMouseDown)
      {
        Point pt = Control.MousePosition;
        int x = this.mouseOffset.X - pt.X;
        int y = this.mouseOffset.Y - pt.Y;

        this.Location = new Point(this.formLocation.X - x, this.formLocation.Y - y);
      }
    }

    private void panelControl_MouseUp(object sender, MouseEventArgs e)
    {
      this.isMouseDown = false;
    }
  }
}
