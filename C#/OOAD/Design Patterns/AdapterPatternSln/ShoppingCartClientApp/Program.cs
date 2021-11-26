using FancyItemsExternalLib.Model;
using ShoppingCartClientApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartClientApp
{
   class Program
    {
        static void Main(string[] args)
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.Add(new HatToItemAdaptor(new Hat("Hat", "Golden ribbon premium hat", 1000)));

            PrintDetails(shoppingCart);
        }

        private static void PrintDetails(ShoppingCart shoppingCart)
        {
            Console.WriteLine("Item Details : ");
            foreach (Item item in shoppingCart.items)
            {
                Console.WriteLine("Item Name  : " + item.ItemName());
                Console.WriteLine("Item Price : " + item.ItemPrice());
            }
        }
    }
}
