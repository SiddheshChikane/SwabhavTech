using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyItemsExternalLib.Model
{
   public class Hat
    {
        public string _shortName;
        private string _longName;
        private double _basePrice;
        private double _gst =8;

        public Hat(string shortName, string longName, double basePrice)
        {
            _shortName = shortName;
            _longName = longName;
            _basePrice = basePrice;
        }

        public string GetShortName
        {
            get
            {
                return _shortName;
            }
        }
        public string GetLongName
        {
            get
            {
                return _longName;
            }
        }
        public double GetPrice
        {
            get
            {
                double finalPrice = _basePrice * _gst/100;
                return _basePrice + finalPrice;
            }
        }
    }
}

