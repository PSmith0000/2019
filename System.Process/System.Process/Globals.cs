using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Process
{
    public class Globals
    {
        public static Dictionary<string, Objects.ProcessObject> OpenHandles = new Dictionary<string, Objects.ProcessObject>();
        public static Objects.ProcessObject GetProcObject(string PrcName)
        {
            return OpenHandles.Where(x => x.Key == PrcName).FirstOrDefault().Value;
        }
    }
}
