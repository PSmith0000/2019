using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Process.Remote
{
    public class Functions
    {
        #region PEB Stuff
        public static void DumpPEB(Objects.ProcessObject p_obj)
        {
            string data = "";
            foreach (var offset in Enum.GetValues(typeof(Unmanaged.WinAPI.PebStructure)))
            {
                var name = Enum.GetName(typeof(Unmanaged.WinAPI.PebStructure), offset);
                var value = Memory.ReadPtr<IntPtr>(p_obj, (long)p_obj.PROCESS_BASIC_INFORMATION.PebBaseAddress, new int[] {(int)offset});
                data += $"{name}, {value}";
            }
             System.IO.File.WriteAllText(@"C:\users\prest\desktop\PEB.txt", data);
        }
        #endregion
    }
}
