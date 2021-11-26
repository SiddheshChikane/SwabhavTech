using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorApp.Model
{
    class PremiumHat : IHat
    {
        private string _name;
        private double _price;
        private string _description;

        public PremiumHat()
        {
            this._name = "Premium";
            this._price = 1000;
            this._description = "Its Premium Hat";
        }

        public string GetDescription()
        {
            return _description;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetPrice()
        {
            return _price;
        }
    }
}
