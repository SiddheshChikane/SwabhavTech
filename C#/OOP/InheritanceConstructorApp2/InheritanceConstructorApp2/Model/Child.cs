using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorApp2.Model
{
    class Child:Parent
    {
        public Child() :base(100)
        {
            Console.WriteLine("Child Created");
            Console.WriteLine(" ");
        }
        public Child(int foo) :base(foo)
        {

        }
    }
}
