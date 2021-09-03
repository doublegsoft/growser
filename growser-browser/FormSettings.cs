using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Growser
{
  public partial class FormSettings : Form
  {
    public FormSettings()
    {
      InitializeComponent();
    }

    private void FormSettings_Load(object sender, EventArgs e)
    {
      try
      {
        NameValueCollection appSettings = ConfigurationManager.AppSettings;
        if (appSettings["organization"] != null)
        {
          textOrganization.Text = appSettings["organization"];
        }
        if (appSettings["host"] != null)
        {
          textHost.Text = appSettings["host"];
        }
        if (appSettings["secret"] != null)
        {
          textSecret.Text = appSettings["secret"];
        }
        if (appSettings["code"] != null)
        {
          textAppCode.Text = appSettings["code"];
        }
      }
      catch (ConfigurationErrorsException ex)
      {

      }

    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void buttonConfirm_Click(object sender, EventArgs e)
    {
      try
      {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings.Remove("organization");
        config.AppSettings.Settings.Remove("host");
        config.AppSettings.Settings.Remove("code");
        config.AppSettings.Settings.Remove("secret");
        config.AppSettings.Settings.Add("organization", textOrganization.Text);
        config.AppSettings.Settings.Add("host", textHost.Text);
        config.AppSettings.Settings.Add("code", textAppCode.Text);
        config.AppSettings.Settings.Add("secret", textSecret.Text);
        config.Save();
        ConfigurationManager.RefreshSection("appSettings");
      }
      catch (ConfigurationErrorsException ex)
      {
        Console.WriteLine("[CreateAppSettings: {0}]",
                          ex.ToString());
        Console.WriteLine();
      }
      DialogResult = DialogResult.OK;
      Close();
    }
  }
}
