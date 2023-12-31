using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodlar_ile_calisma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Muhammed";
            
            //string içerisinde farklı bir metin eklemek için kullanılır.
            var result = sentence.Insert(0, "Deneme, ");

            //girilen değeri belli bir index yerinden parçalamaya yarar.
            var result2 = sentence.Substring(3,4);

            //girilen değerdeki karakterleri büyütür.
            var result3 = sentence.ToUpper();

            //girilen değerdeki karakterlerin yerini değiştirir.
            var result4 = sentence.Replace(" ", "-");
            Console.WriteLine(result4);
            Console.ReadKey();
        }
    }
}
