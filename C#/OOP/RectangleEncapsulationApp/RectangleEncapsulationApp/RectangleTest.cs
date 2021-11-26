using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp.Model
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle small = new Rectangle();
            small.SetWidth(147);
            small.SetHeight(-37);
            Console.WriteLine(small.GetWidth());
            Console.WriteLine(small.GetHeight());
            int smallArea = small.CalcArea(small.GetWidth(),small.GetHeight());
            Console.WriteLine("First Rectangle : width ={0},height={1},area={2}",small.GetWidth(), small.GetHeight(),smallArea);

            Rectangle big = new Rectangle();
            big.SetWidth(107);
            big.SetHeight(67);
            Console.WriteLine(big.GetWidth());
            Console.WriteLine(big.GetHeight());
            int bigArea = big.CalcArea(big.GetWidth(), big.GetHeight());
            Console.WriteLine("Second Rectangle : width ={0},height={1},area={2}",big.GetWidth(), big.GetHeight(), bigArea);

            Console.ReadKey();
        }
    }
}
