using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp.Model
{
    class Account
    {
        private string _accName;
        private int _accNum;
        private double _accBalance;
        private int _MinBalance = 500;

        public Account(string name, int accountNum, double balance)
        {
            _accName = name;
            _accNum = accountNum;
            _accBalance = balance;

        }
        public void DepositMoney(double amt)
        {
            _accBalance += amt;
        }
        public void WithdrawMoney(double amount)
        {
            string LessAmnt = "No Funds";
            string OkAmnt = "No Problem. Its fine";
            if (_accBalance - amount > _MinBalance)
            {
                
                _accBalance -= amount;
                Console.WriteLine(OkAmnt);
            }
            throw new InsuffiecientFundsException(this);
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

