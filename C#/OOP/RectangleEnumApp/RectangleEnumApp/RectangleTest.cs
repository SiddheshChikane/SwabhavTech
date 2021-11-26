using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp.Model
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.width = 102;
            r1.height = 30;
            r1.CalcArea();
            r1.bordercolor = Rectangle.ColorType.blue;
            PrintDetails(r1);
        }
        public static void PrintDetails(Rectangle r)
        {
            Console.WriteLine("Width of Rectangle is  :  {0}", r.width);
            Console.WriteLine("Height of Rectangle is  :  {0}", r.height);
            Console.WriteLine(" ");
            Console.WriteLine("Area of Rectangle is  :  {0}", r.CalcArea());
            Console.WriteLine(" ");
            Console.WriteLine("BorderColor of Rectangle is  :  {0}", r.bordercolor);
            Console.ReadLine();
        }
    }
}
