using FactoryMethodLib.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Factory
{
    public class TeslaFactory:IAutoFactory
    {
        private static TeslaFactory _tFactory;
        private static object locker = new object();

        public TeslaFactory()
        {
            Console.WriteLine("Tesla factory created..");
        }
        public IAuto Make()
        {
            return new Tesla();
        }
        public static TeslaFactory GetInstance()
        {
            lock (locker)
            {
                if (_tFactory == null)
                {
                    _tFactory = new TeslaFactory();
                }
            }
            return _tFactory;
        }
    }
}
