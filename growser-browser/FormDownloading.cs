using Growser.Browser;
using Growser.Update;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Growser.Browser
{
  public partial class FormDownloading : Form
  {

    private string remoteVersion;

    public FormDownloading(string remoteVersion)
    {
      this.remoteVersion = remoteVersion;
      InitializeComponent();
    }

    public void SetProgress(int total, int loaded)
    {
      Invoke((MethodInvoker) delegate() {
        progressDownload.Maximum = total;
        progressDownload.Value = loaded;
      });
    }

    private async void FormDownloading_Shown(object sender, EventArgs e)
    {
      WebClient client = new WebClient();
      Uri uri = new Uri("https://www.cq-fyy.com/dl/app/www.app");

      client.DownloadProgressChanged += (sdr, evt) => {
        SetProgress((int)(evt.TotalBytesToReceive / 1024), (int)(evt.BytesReceived / 1024));
      };
      while (true)
      {
        await client.DownloadFileTaskAsync(uri, "www.app");

        string localVersion = AutoUpdate.Checksum("./www.app");
        if (localVersion.Equals(remoteVersion))
        {
          Hide();
          new FormBrowser().Show();
          break;
        }
        else
        {
          DialogResult result = MessageBox.Show("下载程序出错，是否重新下载？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
          if (!result.Equals(DialogResult.OK))
          {
            Application.Exit();
          }
          else
          {
            progressDownload.Value = 0;
          }
        }
      }
    }
  }
}
