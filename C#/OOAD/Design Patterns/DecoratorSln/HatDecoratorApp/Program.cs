using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HatDecoratorApp.Model;
namespace HatDecoratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IHat hat = new GoldenHat(new StandardHat());
            Console.WriteLine("Name of Hat  : "+hat.GetName());
            Console.WriteLine("Description  : "+hat.GetDescription());
            Console.WriteLine("Price of Hat : "+hat.GetPrice());
        }
    }
}
