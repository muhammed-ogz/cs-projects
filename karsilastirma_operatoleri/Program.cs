using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karsilastirma_operatoleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Program açıklaması : 
            Girilen değerler içerisinde en küçük ve en büyük sayıyı ayıklar. 
            if koşulunda öncelikli olarak değerler 1 girilir. 
            diğer if koşullarında, girilen değerler içerisinde en küçük sayıyı s değerine atar
            en büyük sayıyı k değerine atar bunu if koşulu ile sağlar.
            */
            // < > >= <= = !=
            int k = 0, s = 2, l;
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("{0}. sayiyi giriniz :  \n", i);
                l = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    k = l;
                    s = l;
                }
                if (s > l) s = l;
                if (k < l) k = l;
            }
            Console.WriteLine("Girilen 3 değer içerisinde : \n");
            Console.WriteLine("En büyük sayı : {0} \n", k);
            Console.WriteLine("En küçük sayı : {0} \n", s);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
