using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace AFFViewer.Asc
{
    class AsciiCipher
    {
        private const double Coefficient = 31.6;

        private static string CharecterSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+?=<>,.-\"\': " + Environment.NewLine;
        private static Random random = new Random();

        public static string CreateKey()
        {
            return CharecterSet.OrderBy(c => random.Next(0, CharecterSet.Length)).Select(x => x.ToString()).Aggregate((s1, s2) => { return s1 + s2; });
        }

        public static string Encrypt(string text, string secret)
        {
            List<byte> data = new List<byte>();
     
            text.ToList().ForEach(x => 
            {
                data.Add((byte)Math.Round(Math.Pow((int)secret.IndexOf(x), 2) / Coefficient));
            });

            string base_64 = Convert.ToBase64String(data.ToArray());

            return text == Decrypt(base_64, secret) ? base_64 : null;
        }

        public static string Decrypt(string text, string secret)
        {
            List<byte> data = Convert.FromBase64String(text).ToList();

            string Txt= "";

            data.ForEach(b => 
            {
                Txt += (char)secret[(int)Math.Round(Math.Sqrt(Coefficient * b))];
            });
            
            return Txt;
        }
    }
}
