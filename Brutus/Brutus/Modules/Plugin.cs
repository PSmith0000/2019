using System;
using System.Collections.Generic;
using System.Reflection;

namespace Brutus.Modules
{
    internal class PluginManager
    {
        internal static List<Plugin> LoadedPlugins = new List<Plugin>();
    }

    internal class Plugin : MarshalByRefObject, IDisposable
    {
        public string PluginName { get; set; }
        private Assembly CurrentAssembly { get; set; }

        private int PluginID { get; set; }

        public Plugin(string plugin, AppDomain Sender)
        {
            CurrentAssembly = AppDomain.CurrentDomain.Load(System.IO.File.ReadAllBytes(plugin));
            PluginName = CurrentAssembly.GetName().Name;
            PluginID = (byte)PluginManager.LoadedPlugins.Count + 1;
        }

        public string SendLogin(string combo)
        {
            var one = CurrentAssembly.GetTypes()[0].GetMethod("SendLogin", BindingFlags.Static | BindingFlags.NonPublic);

            return (string)one.Invoke(null, new object[] { combo });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type">The Type in which the method is Associated</param>
        /// <param name="Method">the method name</param>
        /// <param name="Returns">if the method returns a value</param>
        /// <param name="Params">method args</param>
        /// <param name="instance"></param>
        /// <returns></returns>
        public object InvokeMethod(string Type, string Method, bool Returns = false, object[] Params = null, object instance = null)
        {
            if (Returns)
            {
                return CurrentAssembly.GetType(Type).GetMethod(Method).Invoke(instance, Params);
            }
            else
            {
                return CurrentAssembly.GetType(Type).GetMethod(Method).Invoke(instance, Params);
            }
        }

        public void Dispose()
        {
            PluginManager.LoadedPlugins.Remove(this);
            Utils.Utils.SafeInvoke(MainUI._Output, () => {
                MainUI._Output.Items.Add($"Unloaded {PluginName} With ID:{PluginID}");
            });
        }
    }
}