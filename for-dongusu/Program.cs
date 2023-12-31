using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for döngüsü
            // i += 2 i = i + 2 ile aynı sonucu verir.
            for (int i = 0; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished ! Press any key to exit...");
            Console.ReadKey();
        }
    }
}
