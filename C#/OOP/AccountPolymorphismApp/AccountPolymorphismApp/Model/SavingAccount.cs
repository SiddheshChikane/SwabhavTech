using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    class SavingAccount:Account
    {
        public SavingAccount(int accno, string name,double balance) : base(accno, name, balance)
        {
                
        }
        public override void Withdraw(double amt)
        {
            int Min_Bal = 500;
            if(_balance -amt > Min_Bal)
            {
                _balance += amt;
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Balance is low");
            }
        }
    }
}
