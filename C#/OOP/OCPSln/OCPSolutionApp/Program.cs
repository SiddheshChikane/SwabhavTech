using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPSolutionApp.Lib;
using OCPSolutionApp.Client;
namespace OCPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fd = new FixedDeposit("Sid", 200000, 10, new DiwaliFestivalPolicy());
            Console.WriteLine("Simple Interest:" + fd.SimpleIntest());
            Console.ReadKey();
        }
    }
}
