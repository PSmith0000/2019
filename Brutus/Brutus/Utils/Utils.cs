using System;
using System.IO;
using System.Windows.Forms;

namespace Brutus.Utils
{
    internal class Utils
    {
        internal static OpenFileDialog FileDialog = new OpenFileDialog();

        internal static void SafeInvoke(Control ctrl, Action Func, object[] Params = null)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(Func, Params);
            }
            else
            {
                Func();
            }
        }

        internal static int ReadCombos(string FILE)
        {
            FileInfo fi = new FileInfo(FILE);
            if (fi.Exists && fi.Extension == ".txt")
            {
                Settings.Combos.AddRange(File.ReadLines(FILE));
            }
            return Settings.Combos.Count;
        }
    }
}