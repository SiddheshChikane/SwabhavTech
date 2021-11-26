using System;
using ShoppingCartLib.Model;

namespace ConsoleShoppingCart
{
    class Program
    {
        static void Main()
        {
            Customer customer = new Customer(101, "Sid");

            Order order1 = new Order(1001, new DateTime(2021, 02, 12));
            order1.AddItem(new LineItem(1, new Product(201, "Miranda", 40, 60), 4));
            order1.AddItem(new LineItem(2, new Product(201, "Miranda", 40, 60), 6));

            Order order2 = new Order(1002, new DateTime(2021, 06, 15));
            order2.AddItem(new LineItem(1, new Product(303, "Cupboard", 80000, 50), 1));
            order2.AddItem(new LineItem(2, new Product(506, "Umbrella", 6, 60), 10));
            order2.AddItem(new LineItem(3, new Product(908, "Fan", 1323, 60), 2));


            customer.AddOrder(order1);
            customer.AddOrder(order2);


            PrintDetails(customer);
            Console.ReadLine();
        }

        public static void PrintDetails(Customer customer)
        {
            Console.WriteLine($"Customer : {customer.Name}");
            Console.WriteLine($"Number of orders : {customer.OrderCount}");

            foreach (var orderitems in customer.Order)
            {
              
                Console.WriteLine($"Order Number : {orderitems.Id}");
                Console.WriteLine($"Order Date : {orderitems.Date}");
               
                Console.WriteLine("Order Details:");
                Console.WriteLine($"Number of Lineitems  : {orderitems.ItemCount}");
                foreach (var items in orderitems.Items)
                {
                    Console.WriteLine($"\t==>LineItem id : {items.Id}");
                    Console.WriteLine($"\t==>Product id : {items.Product.Id}");
                    Console.WriteLine($"\t==>Product Name : {items.Product.Name}");
                    Console.WriteLine($"\t==>Product Price : {items.Product.Price}");
                    Console.WriteLine($"\t==>Discounted Price : {items.Product.Discount}");
                    Console.WriteLine($"\t==>Quantity : {items.Quantity}");
                    Console.WriteLine($"LineItem total price : {items.Calculate()}");
                    Console.WriteLine(" ");
                }
                Console.WriteLine($"Order Total : {orderitems.GetOrderTotal()}");
            }
            
            Console.WriteLine($"Total of customer {customer.Name} is {customer.CustomerTotal()}");
           
        }
    }
}