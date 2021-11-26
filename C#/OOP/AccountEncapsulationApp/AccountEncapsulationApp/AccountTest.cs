using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountEncapsulationApp;

namespace AccountEncapsulationApp.Model
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            //Part1();
            Part2();
            Console.ReadKey();
        }

        private static void Part2()
        {
            Account[] otherAccounts = new Account[3];
            Account a1 = new Account("Siddhesh", 10010, 6000);
            Account a2 = new Account("Akshay", 10011, 4000);
            Account a3 = new Account("Shivam", 10012, 7000);
            otherAccounts[0] = a1;
            otherAccounts[1] = a2;
            otherAccounts[2] = a3;

            a1.WithdrawMoney(700);
            PrintDetails(otherAccounts[0]);

            a2.WithdrawMoney(4700);
            PrintDetails(otherAccounts[1]);

            a3.DepositMoney(600);
            PrintDetails(otherAccounts[2]);
            

            Account Rich = RichPerson(otherAccounts);
            PrintDetails(Rich);

            DistributeMoney(otherAccounts);
            PrintDetails(otherAccounts);


        }
        private static void Part1()
        {
            Account a1 = new Account("Akshay", 200002, 5000);
            PrintDetails(a1);
            a1.WithdrawMoney(4600);
            PrintDetails(a1);
        }

        private static void PrintDetails(Account a)
        {
            Console.WriteLine("account name: {0}", a.GetAccountName());
            Console.WriteLine("account number: {0}", a.GetAccountNum());
            Console.WriteLine("account balance: {0}", a.GetAccountBalance());
            Console.WriteLine(" ");
        }
        private static void PrintDetails(Account[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("account name: {0}", a[i].GetAccountName());
                Console.WriteLine("account number: {0}", a[i].GetAccountNum());
                Console.WriteLine("account balance: {0}", a[i].GetAccountBalance());
                Console.WriteLine(" ");
            }
           
        }
        private static Account RichPerson(Account[] a)
        {
            double RichAccountBalance = a[0].GetAccountBalance();
            Account RichAccount = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if(RichAccountBalance < a[i].GetAccountBalance())
                {
                    RichAccountBalance = a[i].GetAccountBalance();
                    RichAccount = a[i];

                    Console.WriteLine("Richest person is: ");
                }
            }
            return RichAccount;

        }
        private static void DistributeMoney(Account[] a)
        {
            Account Rich = RichPerson(a);
            double balanceDistribute = Rich.GetAccountBalance() - 500;
            Rich.WithdrawMoney(balanceDistribute);
            for(int i=0; i < a.Length; i++)
            {
                if(a[i].GetAccountNum() != Rich.GetAccountNum())
                {
                    a[i].DepositMoney(balanceDistribute / (a.Length - 1));
                }
                else
                {
                    continue;
                }
            }
        }
             

    }
}




