using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp.Model
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private ColorType _bordercolor;
        private int L_bound = 1;
        private int U_bound = 100;
        public enum ColorType
        {
            red,
            blue,
            green
        }

        public int CalcArea()
        {
            int area = _width * _height;
            return area;
        }
        public int validation(int value)
        {
            if (value < L_bound)
            {
                Console.WriteLine("The Value is set to 1 ", value);
                Console.WriteLine(" ");
                return L_bound;
            }
            else if (value > U_bound)
            {
                Console.WriteLine("The Value is set to 100", value);
                Console.WriteLine(" ");
                return U_bound;
            }
            else
            {
                return value;
            }
        }
        public int width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = validation(value);
            }
        }

        public int height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = validation(value);
            }
        }

        public ColorType bordercolor
        {
            get
            {
                return _bordercolor;
            }
            set
            {
                _bordercolor = value;
            }
        }

    }
}