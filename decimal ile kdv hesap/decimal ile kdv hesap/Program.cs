
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimal_ile_kdv_hesap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(decimal.Add(5.1M, 5.3M)); //add komutu TOPLA demek
            Console.WriteLine(decimal.Subtract(7.0M, 8.3M)); //Subtract komutu ÇIKARTMA demek
            Console.WriteLine(decimal.Multiply(5.3M, 2.6M)); //Multiply komutu BÖLME demek
            Console.WriteLine(decimal.Divide(7.0M, 8.3M)); //Divide komutu ÇARPMA demek
            Console.WriteLine(decimal.Remainder(7.0M, 8.3M)); //Remainder komutu KALAN demek
            Console.WriteLine(decimal.Truncate(7.6M)); //Tam sayı değerini almak için 
            Console.WriteLine(decimal.Negate(7.0M)); //pozitiften negatife çevirme
            Console.WriteLine(decimal.Negate(-7.0M)); //negatiften pozitife çevirme
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();""
        }
    }
}
