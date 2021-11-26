using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp.Model
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private string _color;
        private string _bordercolor="red";


        public float CalcArea()
        {
            return _width * _height;
        }
        public  Rectangle(int width, int height, string color)
        {
            _width = width;
            _height = height;
            _color = ValidateColor(color);
        }
        public  Rectangle(int width, int height, string color,string bordercolor)
        {
            _width = width;
            _height = height;
            _color = ValidateColor(color);
            _bordercolor = ValidateColor(bordercolor);
        }
        private string ValidateColor(string color)
        {
            string _defaulcolor = "red";
            if (color=="red" || color=="blue" || color=="green")
            {
                return color;
            }
            else
            {
                return _defaulcolor;
            }
        }
        public int GetWidth()
        {
            return _width;
        }
        public int GetHeight()
        {
            return _height;
        } 
        public string GetColor()
        {
            return _color;
        }
        public string GetBorderColor()
        {
            return _bordercolor;
        }
    }
}
