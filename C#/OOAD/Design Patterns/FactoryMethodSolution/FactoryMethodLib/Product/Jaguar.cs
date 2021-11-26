using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Product
{
    internal class Jaguar : IAuto
    {
        public void Start()
        {
            Console.WriteLine("Jaguar is Starting..");
        }
        public void Stop()
        {
            Console.WriteLine("Jaguar is Stopping..");
        }
    }
}
