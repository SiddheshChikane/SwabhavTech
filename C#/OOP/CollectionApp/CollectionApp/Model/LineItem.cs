using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp.Model
{
    class LineItem
    {
        private string _productName;
        private double _price;
        private int _quantity;

        public LineItem(string productName, double price,int quantity)
        {
            _productName = productName;
            _price = price;
            _quantity = quantity;
        }
        public string ProductName
        {
            get
            {
                return _productName;
            }
        } 
        public double Price
        {
            get
            {
                return _price;
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }
        public double TotalPrice()
        {
            double _totalPrice = _price * _quantity;
            return _totalPrice;
        }
    }
}
