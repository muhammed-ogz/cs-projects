using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artimetiksel_operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 18;
            Console.WriteLine("a değeri : {0}", a);
            b = 20;
            Console.WriteLine("b değeri : {0}", b);
            // Bölme işlemi yaptırıcam sadece 
            Console.WriteLine("A / B = {0}", a / b);
            float bolme;
            bolme = a / b;
            Console.WriteLine("Floatsız şekilde a / b işlemini ele alırsak eğer sonuç : {0} olur", bolme);
            bolme = (float)a / b;
            Console.WriteLine("Floatlı şekilde a / b işlemini ele alırsak sonuç : {0} olur.", bolme);
            /*
            Bu biçimde bölme işlemini yaptırırsak float olarak yazdıracağımız için virgüllü sonuçlar alacağız..
            */
            // float yazdırmadan da aynı sonucu alabilmek için...
            bolme = 15 / 6f;
            Console.WriteLine("float key ini kullanmadan bölme işlemini virgüllü yapınca sonuç : {0} oldu ", bolme);

            // kalan bulmak için 
            int num1 , num2;
            Console.WriteLine("Kalan bulma programına hoşgeldiniz");
            Console.WriteLine("1. sayıyı giriniz...");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz...");
            num2 = Convert.ToInt32(Console.ReadLine());
            float kalan;
            kalan = num1 % num2;
            Console.WriteLine("girilen 1. sayı  : {0}, \n girilen 2. sayı : {1}. \n bu iki sayının birbirine bölümünden kalan değer : {2}..",num1,num2,kalan);

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
