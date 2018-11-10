using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace System.Process.Remote
{
    class Injection
    {
        private static Dictionary<string, Objects.SWH_Object> Hooked = new Dictionary<string, Objects.SWH_Object>();

        public static void HookInject(Objects.ProcessObject Target, string DllPath, string method)
        {
            FileInfo fi = new FileInfo(DllPath);

            if (fi.Exists)
            {
                IntPtr dll_address = Unmanaged.WinAPI.LoadLibraryEx(fi.FullName, IntPtr.Zero, Unmanaged.WinAPI.LoadLibraryFlags.None);
                IntPtr HookFunc = Unmanaged.WinAPI.GetProcAddress(dll_address, method);

                var _entry = Hooked.Where(x => x.Key == Target.Name);

                if (_entry == null || _entry.FirstOrDefault().Value.IsHooked == IntPtr.Zero)
                {
                    _entry.FirstOrDefault().Value.IsHooked = Unmanaged.WinAPI.SetWindowsHookEx(Unmanaged.WinAPI.HookType.WH_MOUSE, dll_address, HookFunc, 0);
                    if (_entry.FirstOrDefault().Value.IsHooked != IntPtr.Zero){
                        Console.WriteLine("SetWindowsHookEx Was Successful.");
                    }
                    else
                    {
                        Console.WriteLine("SetWindowsHookEx Failed.");
                    }
                }
                else if (_entry.FirstOrDefault().Value.IsHooked != IntPtr.Zero)
                {
                    Console.WriteLine("This Process Already Been Hooked :(");
                }
                else
                {
                    var is_hooked = new Objects.SWH_Object();
                    Hooked.Add(Target.Name, is_hooked);
                    if ((is_hooked.IsHooked = Unmanaged.WinAPI.SetWindowsHookEx(Unmanaged.WinAPI.HookType.WH_KEYBOARD, dll_address, HookFunc, 0)) != IntPtr.Zero)
                    {
                        Hooked.Add(Target.Name, is_hooked);
                         Console.WriteLine("SetWindowsHookEx Was Successful.");
                    }
                    else
                    {
                        Console.WriteLine("SetWindowsHookEx Failed.");
                    }
                }
            }
        }

        public static void LoadLibaryInjection(Objects.ProcessObject Target, string DllPath)
        {
            var fi = new FileInfo(DllPath);

            if (fi.Exists)
            {
                
            }
        }
    }
}
