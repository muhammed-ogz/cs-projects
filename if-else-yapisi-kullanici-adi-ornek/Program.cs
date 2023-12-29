using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_yapisi_kullanici_adi_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi, parola;
            Console.WriteLine("Bir kullanici adi giriniz...");
            kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Bir parola giriniz...");
            parola = Console.ReadLine();

            if (kullaniciAdi == "admin")
            {
                if (parola == "sananeyaraq")
                {
                    Console.WriteLine("Kullanici adi ve parola dogru giris yapiliyor...");
                }
                else
                {
                    Console.WriteLine("Kullanici adi veya parola yanlis. Lutfen tekrar deneyin...");
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
