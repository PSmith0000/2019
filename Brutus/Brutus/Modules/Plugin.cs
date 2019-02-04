using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace Brutus.Modules
{
    internal class PluginManager
    {
        internal static List<Plugin> LoadedPlugins = new List<Plugin>();
    }


    internal class Plugin : MarshalByRefObject
    {
        public string PluginName { get; set; }
        private Assembly CurrentAssembly { get; set; }

        public Plugin(string plugin, AppDomain Sender)
        {
            CurrentAssembly = AppDomain.CurrentDomain.Load(System.IO.File.ReadAllBytes(plugin));
            PluginName = CurrentAssembly.GetName().Name;
        }

        public string SendLogin(string combo)
        {
            var one = CurrentAssembly.GetTypes()[0].GetMethod("SendLogin", BindingFlags.Static | BindingFlags.NonPublic);

            return (string)one.Invoke(null, new object[] {combo});
        }
    }
}
