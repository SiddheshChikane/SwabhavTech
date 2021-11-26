using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            CaseStudy4();
            CaseStudy5();
            Console.ReadKey();
        }
        private static void CaseStudy1()
        {
            Man x;
            x = new Man();
            x.Read();
            x.Walk();
            x.Play();
        } 
        private static void CaseStudy2()
        {
            Boy x;
            x = new Boy();
            x.Jump();
            x.Play();
        } 
        private static void CaseStudy3()
        {
            Boy x;
            x = new Boy();
            x.Read();
            x.Walk();
            x.Jump();
            x.Play();
        }
        private static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
        }
        private static void AtThePark(Man x)
        {
            Console.WriteLine("At The Park");
            x.Play();
        }
        private static void CaseStudy5()
        {
            object x;
            x = 10;
            Console.WriteLine(x.GetType());
            x = "hello World";
            Console.WriteLine(x.GetType());
            x = 23.45f;
            x = new Man();
            Console.WriteLine(x.GetType());

        }

    }
}
