using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLib.Product
{
    public class Audi:IAuto
    {
        public void Start()
        {
            Console.WriteLine("Audi is Starting..");
        } 
        public void Stop()
        {
            Console.WriteLine("Audi is Stopping..");
        }
    }
}
