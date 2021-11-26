using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySyntaxApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo f = new Foo();
            Console.WriteLine(f.Bar);
            f.Bar = 102;
            Console.WriteLine("The Value of Bar is  : {0}",f.Bar);
            Console.WriteLine("The Value of Baz is  : {0}",f.Baz);
            Console.WriteLine("The Value of Baz is  : {0}",f.Baz);
            Console.WriteLine("The Value of Baz is  : {0}",f.Baz);
            Console.ReadKey();

        }
    }
}
