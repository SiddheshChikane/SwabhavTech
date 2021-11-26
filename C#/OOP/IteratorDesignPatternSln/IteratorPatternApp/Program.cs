using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorDesignPatternApp.Model;

namespace IteratorDesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "A";
            a[1] = "B";
            a[2] = "C";
            a[3] = "D";
            a[4] = "E";

            IIterator i = a.CreateIterator();

            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadKey();
        }
    }
}
