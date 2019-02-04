using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brutus.Utils
{
    internal class ComboGenerator 
    {
        public static List<string> CreateFromFile(string path)
        {
            List<string> Combos = new List<string>();
            if (!File.Exists(path))
            {
                return null;
            }
            List<string> Words = File.ReadAllLines(path).ToList();
            for (int one = 0; one < Words.Count; one++)
            {
                for (int two = 1; two < Words.Count; two++)
                {
                    Combos.Add($"{Words[one]}:{Words[two]}");
                }
            }
            return Combos;
        }
    }
}
