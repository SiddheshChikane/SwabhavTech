using AccountToStringEqualityApp.Model;
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
            CaseStudy2();
            Console.ReadKey();
        }
        public static void CaseStudy1()
        {
            Account acc1 = new Account("Siddhesh", 1001, 10000);
            Console.WriteLine(acc1);
            Console.WriteLine(acc1.ToString());
        }
        public static void CaseStudy2()
        {
            Account acc1 = new Account("Siddhesh", 1001, 10000);
            Account acc2 = new Account("Siddhesh", 1001, 10000);
            Console.WriteLine(" ");
            Console.WriteLine(acc1.GetHashCode());
            Console.WriteLine(acc2.GetHashCode());
            Console.WriteLine("Referential Equality  :{0}", acc1==acc2);
            Console.WriteLine("Value Based Equality  :{0}", acc1.Equals(acc2));
        }
    }
}

           