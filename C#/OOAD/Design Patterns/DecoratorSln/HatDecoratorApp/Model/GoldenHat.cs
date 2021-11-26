using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorApp.Model
{
    class GoldenHat : IHatDecorator
    {
        private IHat _hat;
        private double _price = 300;
        private string _name = "Golden";
        private string _description= "It's Golden Hat";

        public GoldenHat(IHat hat)
        {
            this._hat = hat;
        }
        public string GetName()
        {
            return _hat.GetName() + " " + this._name;
        }

        public double GetPrice()
        {
            return _hat.GetPrice() + this._price;
        }

        public string GetDescription()
        {
            return this._description;
        }

       
       
    }
}
