using Growser.HIS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Growser
{
  public static class HISInterfaceProvider
  {

    private static HISSpecificationHost host;

    public static HISSpecificationHost Host
    {
      get
      {
        return host;
      }
    }

    public static void Reload()
    {
      DirectoryInfo dirs = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "/his");
      FileInfo[] files = dirs.GetFiles("*.dll");

      foreach (FileInfo file in files)
      {
        Assembly assembly = Assembly.LoadFile(file.FullName);
        foreach (Type type in assembly.GetTypes())
        {
          if (typeof(HISSpecification).IsAssignableFrom(type))
          {
            HISSpecification spec = (HISSpecification)Activator.CreateInstance(type);
            host = new HISSpecificationHost(spec);
            return;
          }
        }
      }
    }
  }
}
