using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_each_dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             for each dizi ve koleksiyon tabanlı nesnelerin elemanları üzerinde ilerleyen iterasyon
            gerçekleştiren by elemanlara erişip iş katmanı oluşturulabilecek bir döngüdür.
             */
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)   // students için bir döngü oluşturuyoruz ve değerleri student değerine atar.
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
