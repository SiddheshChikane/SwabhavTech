using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactoryLib.Product;
namespace SimpleFactoryLib.Factory
{
    public class AutomobileFactory
    {
        private static AutomobileFactory _autoFactory;
        private static object Locker = new object();

        public AutomobileFactory()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Instance Created");
        }
        public IAuto Make(AutoType type)
        {
            if(type == AutoType.AUDI)
            {
                return new Audi();
            }
            else if(type == AutoType.BMW)
            {
                return new Bmw();

            }
            else
            {
                return new Tesla();

            }
        
        }
        public static AutomobileFactory GetInstance()
        {
            lock (Locker)
            {
                if (_autoFactory == null)
                {
                    _autoFactory = new AutomobileFactory();
                }
            }
            return _autoFactory;
        }
    }
}
