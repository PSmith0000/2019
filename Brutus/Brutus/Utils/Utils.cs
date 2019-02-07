using System;
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
    }
}