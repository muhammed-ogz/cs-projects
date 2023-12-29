using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_yapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secenek;
            Console.WriteLine("Almak istediğiniz içeceğin numarasini giriniz...");
            Console.WriteLine("1.içecek : Su");
            Console.WriteLine("2.içecek : Kola");
            Console.WriteLine("3.içecek : Gazoz");
            Console.WriteLine("4.içecek : Espresso");
            Console.WriteLine("5.içecek : Hibiscus");
            Console.WriteLine("6.içecek : Cappucino");
            Console.WriteLine("7.içecek : Americano");
            Console.WriteLine("8.içecek : Karpuzlu Smootie");
            Console.WriteLine("9.içecek : Ananaslı Smootie");
            Console.WriteLine("10.içecek : Soda");
            secenek = Console.ReadLine();
            switch (secenek)
            {
                case "1":
                Console.WriteLine("Su sectiniz Tutar : 5TL ");
                break;
                case "2":
                Console.WriteLine("Kola sectiniz Tutar 25TL ");
                break;
                case "3":
                Console.WriteLine("Gazoz sectiniz Tutar : 20TL ");
                break;
                case "4":
                Console.WriteLine("Espresso sectiniz Tutar : 30TL ");
                break;
                case "5":
                Console.WriteLine("Hibiscus sectiniz Tutar : 45TL ");
                break;
                case "6":
                Console.WriteLine("Cappucino sectiniz Tutar : 60TL ");
                break;
                case "7":
                Console.WriteLine("Americano sectiniz Tutar : 60TL ");
                break;
                case "8":
                Console.WriteLine("Karpuzlu smootie sectiniz Tutar : 85TL ");
                break;
                case "9":
                Console.WriteLine("Ananasli smootie sectiniz Tutar : 85TL ");
                break;
                case "10":
                Console.WriteLine("Soda sectiniz Tutar : 10TL ");
                break;
                default: 
                Console.WriteLine("Lütfen geçerli bir secenek yaziniz...");
                break;
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
