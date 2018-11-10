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
                int index = 0;
            var names = Enum.GetNames(typeof(Unmanaged.WinAPI.PebStructure));
                foreach (int OFFSET in Enum.GetValues(typeof(Unmanaged.WinAPI.PebStructure)))
                {
                    string Address = Globals.Mem.ReadPtr<IntPtr>(p_obj, (long)p_obj.PROCESS_BASIC_INFORMATION.PebBaseAddress, new int[] { OFFSET }).ToString("X");
                    data += $"{names[index]} -> {Address}{Environment.NewLine}";
                    index++;
                }
            
            System.IO.File.WriteAllText(@"C:\users\prest\desktop\PEB.txt", data);
        }
        #endregion
    }
}
