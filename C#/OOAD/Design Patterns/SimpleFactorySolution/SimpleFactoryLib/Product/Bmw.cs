using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLib.Product
{
    public class Bmw:IAuto
    {
        public void Start()
        {
            Console.WriteLine("BWM is Starting..");
        }
        public void Stop()
        {
            Console.WriteLine("BWM is Stopping..");
        }
    }
}
