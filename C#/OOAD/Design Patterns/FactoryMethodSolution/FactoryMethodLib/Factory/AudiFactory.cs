using FactoryMethodLib.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Factory
{
    public class AudiFactory:IAutoFactory
    {
        private static AudiFactory _aFactory;
        private static object locker = new object();

        public AudiFactory()
        {
            Console.WriteLine("Audi factory created..");
        }
        public IAuto Make()
        {
            return new Audi();
        }
        public static AudiFactory GetInstance()
        {
            lock (locker)
            {
                if (_aFactory == null)
                {
                    _aFactory = new AudiFactory();
                }
            }
            return _aFactory;
        }
    }
}
