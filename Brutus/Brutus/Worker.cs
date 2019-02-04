using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brutus
{
    class Worker
    {
        /// <summary>
        /// For Modules that require just a Combo Parameter
        /// </summary>
        /// <param name="module"></param>
        /// <returns></returns>
        internal static Task<List<string>> doWork(Type module)
        {
            return Task<List<string>>.Factory.StartNew(() => {
                var SendLogin = module.GetMethod("SendLogin", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
                List<string> Logins = new List<string>();
                Settings.Combos.ToList().ForEach(cmb => {
                    var result = (string)SendLogin.Invoke(null, new object[] {cmb});
                    if (result != null) { Logins.Add(result); }
                });
                return Logins;
            });   
        }

        /// <summary>
        /// For Modules that take more then one paramater (array[0] = Combo)
        /// </summary>
        /// <param name="module"></param>
        /// <param name="Params"></param>
        /// <returns></returns>
        internal static Task<List<string>> doWork(Type module, object[] Params)
        {
            return Task<List<string>>.Factory.StartNew(() => {
                var SendLogin = module.GetMethod("SendLogin", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
                List<string> Logins = new List<string>();
                Settings.Combos.ToList().ForEach(cmb => {
                    var args = Params.ToList();
                    args.Insert(0, cmb);
                    var result = (string)SendLogin.Invoke(null, args.ToArray());
                    if (result != null) { Logins.Add(result); }
                });
                return Logins;
            });
        }


        internal static Task<List<string>> doWork(Modules.Plugin plugin)
        {
            return Task<List<string>>.Factory.StartNew(() => {
                List<string> Logins = new List<string>();
                Settings.Combos.ToList().ForEach(cmb => {
                    var login = plugin.SendLogin(cmb);
                    if (login != null)
                    {
                        Logins.Add(login);
                    }
                });
                return Logins;
            });
        }
    }
}
