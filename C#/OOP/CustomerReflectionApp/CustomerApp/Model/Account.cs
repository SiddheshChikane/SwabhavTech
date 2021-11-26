using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Model
{
    class Account
    {
        private string _Cname;
        private string _Cid;
        private float _Cbalance;
        private GenderType _gender;
        private static int _count;

        static Account()
        {
            _count = 1001;
        }
        public  Account(string name, float balance)
        {
            _Cname = name;
            _Cbalance = balance;
            _Cid = "C" + _count;
            _count += 1;

        }
        public  Account(string name, float balance,GenderType gender)
        {
            _Cname = name;
            _Cbalance = balance;
            _Cid = "C" + _count;
            _count += 1;

        }
        public string name
        {
            get
            {
                return _Cname;
            }
        }
        public string ID
        {
            get
            {
                return _Cid;
            }
        } 
        public float Balance
        {
            get
            {
                return _Cbalance;
            }
        }
        public GenderType gender
        {
            get
            {
                return _gender;
            }
        }
        
    }
}
