using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactoryLib.Factory;
namespace SimpleFactoryClientApp
{
     class Program
    {
        static void Main(string[] args)
        {
            var f1 =  AutomobileFactory.GetInstance();
            var auto = f1.Make(SimpleFactoryLib.Factory.AutoType.TESLA);
            auto.Start();
            auto.Stop();
            Console.WriteLine(f1.GetHashCode());

            var f2 = AutomobileFactory.GetInstance();
            var auto1 = f2.Make(SimpleFactoryLib.Factory.AutoType.AUDI);
            auto.Start();
            auto.Stop();
            Console.WriteLine(f2.GetHashCode());
        }
    }
}
