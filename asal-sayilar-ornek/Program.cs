using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asal_sayilar_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("which number is prime or not?");
            num = Convert.ToInt32(Console.ReadLine());

            if (IsPrimeNumber(num))
            {
                Console.WriteLine("This is a prime number !");
            }
            else
            {
                Console.WriteLine("This is not a prime number !");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        // program açıklaması : girilen sayının asal olup olmadığını bulan bir program..
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % 2 == 0)
                {
                    result = false;
                    i = number; // 1000 gibi büyük sayılarda performans problemini kesmek için boolean değeri değişirse
                    //i değerini çıkan değere eşitler ve döngüyü otomatik keser.
                }
            }
            return result;
        }
    }
}
