using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ProductApp.Model
    {
        class Product
        {
            private int _id;
            private string _name;
            private float _price;
            private float _discountPercent;
            private static int _Instancecount = 0;

            public Product(int id, string name, float price, float discountPercent)
            {
                _id = id;
                _name = name;
                _price = price;
                _discountPercent = discountPercent;
                _Instancecount += 1;
                Console.WriteLine("Constructor 2");
            }
            public Product(int id, string name, float price)
            {
                _id = id;
                _name = name;
                _price = price;
                _discountPercent = 0.2f;
                _Instancecount += 1;
                Console.WriteLine("Constructor 1");
            }
            static Product()
            {
                _Instancecount = 0;
                Console.WriteLine("Static Constructor:");
            }
            public static int Occurance
            {
                get
                {
                    return _Instancecount;
                }
            }
          
            public int ID
            {
                get
                {
                    return _id;
                }
            }
            public string Name
            {
                get
                {
                    return _name;
                }
            }
            public double Price
            {
                get
                {
                    return _price;
                }
            }
            public float DiscountPercent
            {
                get
                {
                    return _discountPercent;
                }
            }
            public int InstanceCount
            {
                get
                {
                    return _Instancecount;
                }
            }
            public float Discount
            {
                get
                {
                    return _discountPercent;
                }
            }
            public float CalcFinalPrice()
            {
                return _price - (_price * _discountPercent / 100); 
            }
        }
    }
}