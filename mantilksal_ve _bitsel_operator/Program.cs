using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantilksal_ve__bitsel_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // && = ve , || = veya , ! = değil
            int a, b, c;
            Console.WriteLine("'a' değerini giriniz : \n");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("'b' değerini giriniz : \n");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("iki sayının toplamı : {0}",c);
            if(c != 25){
                Console.WriteLine("2 sayının toplamı 25 değildir.");
                
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
