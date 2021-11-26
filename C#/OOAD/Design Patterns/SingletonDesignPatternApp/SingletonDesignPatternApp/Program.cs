using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SingletonDesignPatternApp;
namespace SingletonDesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part3();
            Part4();
        }

        private static void Part3()
        {
            var sv1 = DataService.GetInstance();
            var sv2 = DataService.GetInstance();
            Console.WriteLine(sv1.GetHashCode());
            Console.WriteLine(sv2.GetHashCode());

            sv1.DoSomething();
            sv2.DoSomething();
        }

        private static void Part4()
        {
            Thread t1 = new Thread(() =>
            {
                DataService.GetInstance().DoSomething();
            });
            Thread t2 = new Thread(() =>
            {
                DataService.GetInstance().DoSomething();
            });

            t1.Start();
            t2.Start();
        }
    }
}
