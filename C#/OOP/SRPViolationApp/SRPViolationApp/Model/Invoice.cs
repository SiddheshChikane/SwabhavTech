using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolationApp.Model
{
    class Invoice
    {
        private int _id;
        private string _description;
        private double _amount;
        private float _tax;
        private float _discount;

        public Invoice(int id, string description,double amount,float tax,float discount)
        {
            this._id = id;
            this._description = description;
            this._amount = amount;
            this._tax = tax;
            this._discount = discount;
        }
        public int Id
        {
            get
            {
                return _id;
            }
        } 
        public string Description
        {
            get
            {
                return _description ;
            }
        } 
        public double Amount
        {
            get
            {
                return _amount ;
            }
        }
        public double Tax
        {
            get
            {
                return _tax ;
            }
        } 
        public double Discount
        {
            get
            {
                return _discount ;
            }
        }
        public double CalculateDiscount()
        {
            _discount = (float)(_amount * _discount / 100);
            return _discount;
        }    
        public double  CalculateTax()
        {
            _tax = (float)(_amount * _tax / 100);
            return _tax;
        }     
        public double  CalculateFinalAmount()
        {
             _amount = (float)_amount - _discount + _tax;
            return _amount;
        }
       
    }
}
