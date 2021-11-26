using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPViolationApp.Model;
namespace OCPViolationApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd1 = new FixedDeposit("Sid", 40000, 6, FestivalType.DIWALI);
            Console.WriteLine("Simple Interest :"+fd1.SimpleInterest());
            Console.ReadKey();
        }
    }
}
