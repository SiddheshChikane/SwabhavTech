using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            Console.ReadKey();
        }

        private static void CaseStudy1()
        {
            Account a1 = new Account("Shivam", 5000);
            Account a2 = new Account("Akshay", 10000);
            Account a3 = new Account("Siddhesh", 15000);
            Account a4 = new Account("Yogeshwar", 50000, GenderType.Male);
            Console.WriteLine(a1.ID);
            Console.WriteLine(a2.ID);
            Console.WriteLine(a3.ID);
            Console.WriteLine(a4.ID);
            PrintDetails(a1);
            PrintDetails(a2);
            PrintDetails(a3);
            PrintDetails(a4);

            Reflection RFC = new Reflection();
            RFC.DoReflection(a4);
        }

        private static void PrintDetails(Account a)
        {
            Console.WriteLine("Account Holder name        : {0}",a.name);
            Console.WriteLine("Account Holder ID          : {0}" ,a.ID);
            Console.WriteLine("Account Holder Balance     : {0}",a.Balance);
            Console.WriteLine("Account Holder GenderType  : {0}",GenderType.Male );
            Console.WriteLine(" ");
        }
    }
}
