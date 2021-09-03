using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Dynamic;

namespace Growser.Common.JS
{
  public class GrowserObject
  {

    private Dictionary<string, object> userdata = new Dictionary<string, object>();

    public void SetUser(ExpandoObject user)
    {
      IDictionary<string, object> dict = (IDictionary<string, object>)user;
      foreach (string key in dict.Keys) 
      {
        userdata[key] = dict[key];
      }
    }

    public void GetUser()
    {
      // MessageBox.Show((string)userdata["fullname"]);
    }

    public string GetHost()
    {
      NameValueCollection appSettings = ConfigurationManager.AppSettings;
      return appSettings["host"];
    }

    public string GetAppCode()
    {
      NameValueCollection appSettings = ConfigurationManager.AppSettings;
      return appSettings["code"];
    }
  }
}
