using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while döngüsü 
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
            
        }
    }
}
