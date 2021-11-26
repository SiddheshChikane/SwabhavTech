using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorApp2.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            Console.WriteLine(c.Foo);
            Child c1 = new Child(300);
            Console.WriteLine(c1.Foo);
            Console.ReadKey();

        }
    }
}
