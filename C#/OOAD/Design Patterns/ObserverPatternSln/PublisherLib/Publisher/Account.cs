using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLib.Publisher
{
    public class Account
    {
        private int _accno;
        private string _name;
        private double _balance;
        private string _email;
        private List<INotifier> _notifiers = new List<INotifier>();

        public Account(int accno, string name, double balance,string email)
        {
            this._accno = accno;
            this._name = name;
            this._balance = balance;
            this._email = email;
        }
        public void Deposit(double amount)
        {
            _balance += amount;
            Notify();
        } 
        private void Notify()
        {
            foreach (INotifier notifier in _notifiers)
            {
                notifier.Notify(this);
            }
        }
        public void Withdraw(double amount)
        {
            _balance -= amount;
            Notify();
        }
        public void AddNotifier(INotifier notifier)
        {
            _notifiers.Add(notifier);
        }
        public int AccNo
        {
            get
            {
                return _accno;
            }
        } 
        public double Balance
        {
            get
            {
                return _balance;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
        }
    }
}
