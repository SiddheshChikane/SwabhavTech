using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorApp.Model
{
    class StandardHat : IHat
    {
        private string _name;
        private double _price;
        private string _description;

        public StandardHat()
        {
            this._name = "Standard";
            this._price = 400;
            this._description = "Its Standard Hat";
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
