using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorApp.Model
{
    class RibbonedHat : IHatDecorator
    {
        private IHat _hat;
        private double _price = 300;
        private string _name = "Ribbon";
        private string _description = "It's Ribboned Hat";

        public RibbonedHat(IHat hat)
        {
            this._hat = hat;
        }
        public string GetDescription()
        {
            return this._description;
        }

        public string GetName()
        {
            return _hat.GetName() + " " +this._name;
        }

        public double GetPrice()
        {
            return _hat.GetPrice() + this._price;
        }
    }
}
