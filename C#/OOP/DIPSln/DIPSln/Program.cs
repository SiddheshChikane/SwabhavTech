using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPSln.High_Level_Module;
using DIPSln.Common_Module;
using DIPSln.Low_Level_Module;
namespace DIPSln
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator calc = new TaxCalculator(new FileLogger());
            Console.WriteLine(calc.Calculate(30,20));
            Console.WriteLine(calc.Calculate(50, 0));
        }
    }
}
