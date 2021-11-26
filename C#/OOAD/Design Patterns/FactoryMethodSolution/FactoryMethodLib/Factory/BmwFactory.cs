using FactoryMethodLib.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Factory
{
    public class BmwFactory:IAutoFactory
    {
        private static BmwFactory _bFactory;
        private static object locker = new object();

        public BmwFactory()
        {
            Console.WriteLine("BMW factory created..");
        }
        public IAuto Make()
        {
            return new Bmw();
        }
        public static BmwFactory GetInstance()
        {
            lock (locker)
            {
                if (_bFactory == null)
                {
                    _bFactory = new BmwFactory();
                }
            }
            return _bFactory;
        }
    }
}
