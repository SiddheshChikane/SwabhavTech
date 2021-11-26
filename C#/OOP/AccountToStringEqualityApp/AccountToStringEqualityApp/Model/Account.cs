using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountToStringEqualityApp.Model
{
    class Account
    {
        private string _name;
        private int _accid;
        private double _accbalance;
        public Account(string name, int id, double accbalance)
        {
            _name = name;
            _accid = id;
            _accbalance = accbalance;
        }
        public override string ToString()
        {
            string str = "Child-->Name " + _name + "ID: " + _accid + "Balance : " + _accbalance;
            Console.WriteLine(" ");
            return str+"\n Parent-->"+ base.ToString();
        }
        public override bool Equals(object obj)
        {
            if(_name == ((Account)obj).name || _accid == ((Account)obj).ID)
            {
                return true;
            }
            else
            {
                return base.Equals(obj);
            }
            
        }
        public string name
            {
                get
                {
                    return _name;
                }
            }
            public int ID
            {
                get
                {
                    return _accid;
                }
            }
            public double Balance
            {
                get
                {
                    return _accbalance;
                }
            }
          
       

        }
    }



