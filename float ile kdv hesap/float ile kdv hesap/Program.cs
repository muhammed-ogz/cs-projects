using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace float_ile_kdv_hesap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ürünün KDV'siz fiyatını giriniz...");
            float kdvsiz = float.Parse(Console.ReadLine());
            var kdvli = kdvsiz + (kdvsiz * 0.18);
            Console.WriteLine("Kdv' li fiyat : " + kdvli);
            Console.WriteLine("Press any key to exit");
            // tostringi floatta kullanmaya gerek yok double da kullanmak zorundayız ama
            Console.ReadKey();
        }
    }
}
