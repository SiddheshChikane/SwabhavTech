using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPatternApp
{
    class DataService
    {
        private static DataService _bucket;
        private static Object locker = new object();
        public DataService()
        {
            Console.WriteLine("DataService Created..");
        }
        public void DoSomething()
        {
            Console.WriteLine("Work Done by "+this.GetHashCode());
        }
        //part 3

        /*public static DataService GetInstance()
        {
          if(_bucket == null)
            {
                _bucket = new DataService();
            }
            return _bucket;
        }*/

        //part 4

        public static DataService GetInstance()
        {
            if (_bucket == null)
            {
                lock (locker)
                {
                    if(_bucket == null)
                    {
                        _bucket = new DataService();
                    }
                    
                }
            }
            return _bucket;
        }

    }
}
