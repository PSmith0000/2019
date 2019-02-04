using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPlugin
{
    public class BrutusMod
    {
        static int i = 20;

        static string SendLogin(string userpass)
        {
            i += i * 43;
            if (i % 3 == 0)
            {
                return "CORRECT_" + i++;
            }
            return null;
        }
    }
}
