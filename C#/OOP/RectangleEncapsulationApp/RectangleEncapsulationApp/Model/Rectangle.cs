using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp.Model
{
    class Rectangle
    {
        public int width,height;
        public int L_bound = 1;
        public int U_bound = 100;
        public void SetWidth(int pwidth)
        {
            width = pwidth;
        }
        public void SetHeight(int pheight)
        {
            height = pheight;
        }
        public int GetWidth()
        {
            width = doValidate(width);
            return width;
        }
        public int GetHeight()
        {
            height = doValidate(height);
            return height;
        }
        public int doValidate(int value)
        {
            if (value < L_bound)
            {
                Console.WriteLine("Lower Bound={0} = 1",value);
                return L_bound;
            }
            else if (value > U_bound)
            {
                Console.WriteLine("Upper Bound={0} = 100",value);
                return U_bound;
            }
            else
            {
                return value;
            }
        }
        public int CalcArea(int pwidth, int pheight)
        {
           width = doValidate(pwidth);
            height = doValidate(pheight);
            return width *height;
        }
        
        
    }
}
