using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Brutus.Reflection
{
    internal class ModuleManager
    {
        private static AppDomain domain { get; set; }

        static ModuleManager()
        {
            domain = AppDomain.CreateDomain("Plugins");
            domain.DomainUnload += Domain_DomainUnload;
        }

        internal static void LoadModules()
        {
            if (Directory.Exists(Application.StartupPath + @"\Plugins"))
            {
                Directory.GetFiles(Application.StartupPath + "\\Plugins", "*.dll").ToList().ForEach(plugin =>
                {
                    if (Utils.PE.ValidDotNetPE(plugin))
                    {
                        var asmDef = AssemblyDefinition.ReadAssembly(plugin);
                        if (asmDef.MainModule.GetTypes().Where(x => x.Name == "BrutusMod").Count() != 0 && asmDef.MainModule.GetTypes().Where(x => x.Name == "BrutusMod").FirstOrDefault().Methods.Where(x => x.Name == "SendLogin").Count() != 0)
                        {
                            var type = typeof(Brutus.Modules.Plugin);
                            var p = (Brutus.Modules.Plugin)domain.CreateInstanceAndUnwrap(Assembly.GetAssembly(type).FullName, type.ToString(), false, BindingFlags.CreateInstance, null, new object[] {plugin, AppDomain.CurrentDomain}, null, null);
                            MainUI._Output.Items.Add("Loaded Module: " + p.PluginName);
                            MainUI._ModuleList.Items.Add(p.PluginName);
                            Brutus.Modules.PluginManager.LoadedPlugins.Add(p);
                        }
                        else
                        {
                            MainUI._Output.Items.Add("Invalid Plugin Format! " + asmDef.Name);
                        }
                    }
                    else
                    {
                        MainUI._Output.Items.Add("Not A Valid PE: " + plugin);
                    }
                });
                MainUI._Output.Items.Add("Loaded " + Brutus.Modules.PluginManager.LoadedPlugins.Count() + " Plugins!");
            }
        }

        internal static void UnloadModules()
        {
            AppDomain.Unload(domain);
        }

        private static void Domain_DomainUnload(object sender, EventArgs e)
        {
          
            Modules.PluginManager.LoadedPlugins.Clear();
        }
    }
}