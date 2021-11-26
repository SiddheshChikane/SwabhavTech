using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSerializationApp.Model
{
    [Serializable]
    class Account
    {
        private float _balance;

        public Account(float balance)
        {
            this._balance = balance;
        }
        public void Withdraw(float amount)
        {
            _balance -= amount;
            Console.WriteLine("Amount Withdraw Successfully : {0}", amount);
        }
        public float Balance
        {
            get
            {
                return _balance;
            }
        }
    }
}
