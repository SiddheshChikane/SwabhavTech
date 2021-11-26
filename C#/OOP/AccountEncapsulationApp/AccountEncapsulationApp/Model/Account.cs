using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEncapsulationApp.Model
{
    class Account
    {
        private string _accName;
        private int _accNum;
        private double _accBalance;
        private int _MinBalance = 500;

        public  Account(string name,int accountNum,double balance)
        {
            _accName = name;
            _accNum = accountNum;
            _accBalance = balance;

        }
        public void DepositMoney(double amt)
        {
            _accBalance += amt;
        }
        public  void WithdrawMoney(double amount)
        {
            string LessAmnt = "No Funds";
            string OkAmnt = "No Problem. Its fine";
            if (_accBalance - amount < _MinBalance)
            {
                Console.WriteLine(LessAmnt);
            }
            else
            {
                _accBalance -= amount;
                Console.WriteLine(OkAmnt);
               
            }
        }
        public string GetAccountName()
        {
            return _accName;
        }
        public int GetAccountNum()
        {
            return _accNum;
        }
        public double GetAccountBalance()
        {
            return _accBalance;
        }
    }
}
