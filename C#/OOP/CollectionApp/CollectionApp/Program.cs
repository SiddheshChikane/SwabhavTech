using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CollectionApp.Model

{
    class Program
    {
        static void Main(string[] args)
        {
           // CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy1()
        {
            ArrayList basket = new ArrayList();
            basket.Add(new LineItem("Shoes", 1000, 1));
            basket.Add(new LineItem("Cap", 200, 3));
            basket.Add(new LineItem("Watch", 2000, 2));
            basket.Add("Aurion Pro");

            double finalPrice = 0;
            foreach (LineItem item in basket)
            {
                Console.WriteLine("Product Name  :{0} , Price : {1}, Quantity :{2}",
                    item.ProductName,item.Price,item.Quantity);
                Console.WriteLine("Total Price of Products : {0}",item.TotalPrice());
                finalPrice += item.TotalPrice();
            }
            Console.WriteLine("Final Price of Products : {0}", finalPrice);
            Console.ReadKey();
        }
        private static void CaseStudy2()
        {
            List<LineItem> basket = new List<LineItem>();
            basket.Add(new LineItem("Shoes", 1000, 1));
            basket.Add(new LineItem("Cap", 200, 3));
            basket.Add(new LineItem("Watch", 2000, 2));

            double finalPrice = 0;
            foreach (LineItem item in basket)
            {
                Console.WriteLine("Product Name  :{0} , Price : {1}, Quantity :{2}",
                    item.ProductName, item.Price, item.Quantity);
                Console.WriteLine("Total Price of Products : {0}", item.TotalPrice());
                finalPrice += item.TotalPrice();
            }
            Console.WriteLine("Final Price of Products : {0}", finalPrice);
            Console.ReadKey();
        }
    }
}
