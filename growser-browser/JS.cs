using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Growser.Browser.JS
{
  public class GrowserObject
  {

    private Dictionary<string, object> userdata = new Dictionary<string, object>();

    public void Show(string message)
    {
      MessageBox.Show(message);
    }

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
      MessageBox.Show((string)userdata["fullname"]);
    }
  }
}
