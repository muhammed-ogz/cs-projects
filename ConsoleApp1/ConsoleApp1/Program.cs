using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KDV hesaplama programı 
            double fiyat, kdv, toplam;
            Console.WriteLine("Ürünün KDV'siz fiyatını giriniz");
            fiyat = Convert.ToDouble(Console.ReadLine());   // ReadLine Değerini double' a çeviriyor alıyoruz
            kdv = fiyat * 18 / 100;
            toplam = fiyat + kdv;
            Console.WriteLine("KDV' li fiyat : " + toplam.ToString());  
            Console.WriteLine("Press any key to exit...");
            /* 
            Double değeri ekrana yazdırırken x.ToString(); methodunu kullanmak gerekiyor...
            */
            Console.ReadKey();
        }
    }
}
