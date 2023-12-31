using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_methodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string nedir ? 
            string nesnesel verileri tutmak için kullanılan değişken tipidir. 
            stringler aslında birer char arraydir.
            */
            string city = "Kayseri";
            string city2 = "Istanbul";
            //Console.WriteLine(city[0]);
            foreach (var item in city) {
                Console.WriteLine(item);
            }

            //stringler toplanabilir
            //var result = city + " " + city2;
            //Console.WriteLine(result); bunun yerine 
            Console.WriteLine(String.Format("{0} {1}", city, city2));

            Console.ReadKey();
        }
    }
}
