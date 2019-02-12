using System;
using System.IO;
using System.Windows.Forms;

namespace Brutus.Utils
{
    internal class PE
    {
        internal static bool ValidDotNetPE(string file)
        {
            bool bstate = false;
            ushort dataDictionaryStart;

            uint[] dataDictionaryRVA = new uint[16];

            uint[] dataDictionarySize = new uint[16];

            Stream fs = new FileStream(file, FileMode.Open, FileAccess.Read);

            BinaryReader reader = new BinaryReader(fs);

            fs.Position = 0x98;

            dataDictionaryStart = Convert.ToUInt16(Convert.ToUInt16(fs.Position) + 0x60);

            fs.Position = dataDictionaryStart;


            for (int i = 0; i < 15; i++)
            {
                dataDictionaryRVA[i] = reader.ReadUInt32();

                dataDictionarySize[i] = reader.ReadUInt32();
            }

            if (dataDictionaryRVA[14] != 0)
            {
                bstate = true;
            }


            fs.Close();
            return bstate;
        }
    }
}