using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_yapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if else yapısı 

            int a, b, kalan;
            a = 0; b = 0;
            Console.WriteLine("********KALAN HESAPLAMA********");
            Console.WriteLine("1. değerinizi (ana sayı) giriniz : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. değerinizi (kaç ile bölüneceğini) giriniz : ");
            b = Convert.ToInt32(Console.ReadLine());
            kalan = a % b;
            if(kalan == 0){
                Console.WriteLine("İki sayının birbirine bölümünden kalanı 0' a eşittir.");
            }else{
                Console.WriteLine("İki sayının birbirine bölümünden kalan : {0}", kalan);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
