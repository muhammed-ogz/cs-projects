using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            do while döngüsünde döngü en az bir kere çalıştırılır. While döngüsünden farkı ise en başta 
            do koşulu ile döngü kontrol edilir.

            do{

            }while(koşul){

            }

            böyle bir kalıbı vardır...
            */

            int toplam = 0;
            int sayac = 0;
            do
            {
                sayac++;
                toplam += sayac;
            } while (sayac < 100);
            Console.WriteLine("Toplam : " + toplam.ToString() + ",Sayaç : " + sayac.ToString());
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
