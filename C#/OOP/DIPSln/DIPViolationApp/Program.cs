using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPViolationApp.HighLevelModule;

namespace DIPViolationApp.HighLevelModule
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new TaxCalculator(LogType.DB);
            Console.WriteLine(calc.Calculate(20, 10));
            Console.WriteLine(calc.Calculate(30, 0));
            Console.ReadLine();
        }
    }
}
