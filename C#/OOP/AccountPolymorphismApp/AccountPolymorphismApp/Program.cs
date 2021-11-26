using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount ac1 = new SavingAccount(101, "Siddhesh", 2000);
            PrintDetails(ac1);
            CurrentAccount ac2 = new CurrentAccount(102, "Akshay", 4000);
            PrintDetails(ac2);

            ac1.Withdraw(1501);
            PrintDetails(ac1);

            ac2.Withdraw(10000);
            PrintDetails(ac2);
            Console.ReadKey();
        }
        public static void PrintDetails(Account ac)
        {
            Console.WriteLine("Holder's Account Number    : {0}",ac.Accno);
            Console.WriteLine("Account Holder's Name      : {0}",ac.Name);
            Console.WriteLine("Account Holder's Balance   : {0}",ac.Balance);
        }
    }
}
