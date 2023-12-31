using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add();
            customerManager.Update();

            Customer customer = new Customer();
            customer.city = "Ankara";
            customer.Id = 1;
            customer.firstName = "Cebiratül";
            customer.lastName = "Garademlik Çayı";

            //class girdilerini bu şekilde de yazabiliriz..
            Customer customer2 = new Customer
            {
                Id = 2,
                city = "Kayseri",
                firstName = "Kestaneci",
                lastName = "Gardaşlıkevlatları"
            };

            Console.WriteLine("Welcome " + customer.firstName + " " + customer.lastName);
            Console.ReadKey();
        }
    } 
}
