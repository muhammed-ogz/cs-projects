using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_sbyte_short_kullani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******SINAV NOT LİSTESİ*******");
            sbyte turkce, mat, fen, sos;
            turkce = -4;
            mat = 24;
            fen = 13;
            sos = 0;
            Console.WriteLine("Türkçe' de 40 soru içerisinde " +  turkce + " netiniz vardır...");
            Console.WriteLine("Sosyal Bilimler' de 20 soru içerisinde " + sos + " netiniz vardır...");
            Console.WriteLine("Matematik' de 40 soru içerisinde " + mat + " netiniz vardır...");
            Console.WriteLine("Fen Bilimleri' nde 20 soru içerisinde " + fen + " netiniz vardır...");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
