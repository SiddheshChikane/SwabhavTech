using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("Sid", 1001, 2000);
            try
            {
               
                acc1.WithdrawMoney(4501);
            }
            catch(InsuffiecientFundsException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Executes not matter exception or not");
                PrintDetails(acc1);
            }
            Console.WriteLine("End of Main"); 
        }

        static void PrintDetails(Account acc)
        {
            Console.WriteLine("Acc Holder Name            : {0}", acc.GetAccountName());
            Console.WriteLine("Acc Holder Account Number  : {0}", acc.GetAccountNum());
            Console.WriteLine("Acc Holder Balance         : {0}", acc.GetAccountBalance());
        }
    }
}
