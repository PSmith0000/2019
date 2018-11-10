using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Process.Objects
{
    public class ProcessObject : IDisposable
    {
        public ProcessObject(string PrcName)
        {
            Process = System.Diagnostics.Process.GetProcessesByName(PrcName)[0];
            PID = Process.Id;
            Name = PrcName;
            Handle = Unmanaged.WinAPI.OpenProcess(Unmanaged.WinAPI.ProcessAccessFlags.All, false, Process.Id);
            if (Handle == null)
            {
                //Debug Out
                Dispose();
            }
            else
            {
                if(Globals.OpenHandles.Where(x => x.Key == PrcName).Count() == 0)
                {
                    Globals.OpenHandles.Add(PrcName, this);
                    Memory.GetProcessInfo(this);
                }
                else
                {
                    Dispose();
                }
            }
        }

        public string Name { get; private set; }
        
        public int PID { get; private set; }

        public Unmanaged.WinAPI.ProcessAccessFlags ProcessAccess { get; set; }

        public IntPtr Handle { get; private set; }

        public Unmanaged.WinAPI.PROCESS_BASIC_INFORMATION PROCESS_BASIC_INFORMATION { get; set; }

        public System.Diagnostics.Process Process { get; set; }

        public void Dispose()
        {
            
        }
    }
}
