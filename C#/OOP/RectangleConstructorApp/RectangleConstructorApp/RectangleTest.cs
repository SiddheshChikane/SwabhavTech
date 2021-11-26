using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp.Model
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            Console.ReadKey();
        }
        public static void CaseStudy1()
        {
            Rectangle r1 = new Rectangle(120, 30, "blue");
            PrintDetails(r1);
        }
        public static void CaseStudy2()
        {
            Rectangle r1 = new Rectangle(60, 40, "green", "black");
            PrintDetails(r1);
        }
        private static void PrintDetails(Rectangle c)
        {
            Console.WriteLine("Width of Rectangle is: {0}", c.GetWidth());
            Console.WriteLine("Height of Rectangle is: {0}",c.GetHeight());
            Console.WriteLine("Color of Rectangle is: {0}",c.GetColor());
            Console.WriteLine("BorderColor of Rectangle is: {0}",c.GetBorderColor());
            Console.WriteLine("Area of Rectangle is: {0}", c.CalcArea());
            Console.WriteLine(" ");
        }

    }
}
