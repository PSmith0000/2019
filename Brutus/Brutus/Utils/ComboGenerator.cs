using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Brutus.Utils
{
    internal class ComboGenerator
    {
        public static Task<List<string>> CreateFromFile(string path)
        {
            return Task.Factory.StartNew(() =>
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
                        var wordX = $"{Words[one]}:{Words[two]}";
                        Combos.Add(wordX);
                    }
                }
                GC.Collect();
                return Combos;
            });
        }
    }
}