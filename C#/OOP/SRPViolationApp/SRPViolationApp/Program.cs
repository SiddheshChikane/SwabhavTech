using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRPViolationApp.Model;
namespace SRPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(101,"Solar Power Invoice",200000,10,50);
            Print(inv);
            Console.ReadKey();
        }
        public static void Print(Invoice inv)
        {
            Console.WriteLine("***********Invoice Details************\n");
            Console.WriteLine(" Invoice Id: {0}", inv.Id);
            Console.WriteLine(" Invoice Description: {0}", inv.Description);
            Console.WriteLine(" Invoice Amount: {0}", inv.Amount);
            Console.WriteLine(" Invoice GST tax: {0}%", inv.Tax);
            Console.WriteLine(" Invoice Discount: {0}%", inv.Discount);
            Console.WriteLine(" Discounted amount: {0}", inv.CalculateDiscount());
            Console.WriteLine(" Tax amount: {0}", inv.CalculateTax());
            Console.WriteLine(" Final amount: {0}", inv.CalculateFinalAmount());
        }
    }
}
