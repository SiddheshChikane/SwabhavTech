using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleEncapsulationApp.Model
{
    class Circle
    {
        private float C_radius = 4f;
        private string C_bordercolor="green";
        private string C_fillcolor="blue";
        private float L_Bound = 1;
        private float U_Bound = 10;
        public float CalcArea()
        {
            return (3.14f * C_radius * C_radius);
        }
        public float ValidationRadius(float radius)
        {
             
            if (radius < L_Bound)
            {
                return L_Bound;
            }
            else if (radius > U_Bound)
            {
                return U_Bound;
            }
            else
            {
                return radius;
            }
        }
        private string ValidationColor(string color)
        {
            string default_color = "red";
            if (color == "red" || color == "blue" || color == "green")
            {
                return color;
            }
            else
            {
                return default_color;
            }
        }
        public void SetRadius(float radius)
        {
            C_radius = ValidationRadius(radius);
        }
        public void SetBorderColor(string bordercolor)
        {
            C_bordercolor = ValidationColor(bordercolor);
        }
        public void SetFillColor(string fillcolor)
        {
            C_fillcolor = ValidationColor(fillcolor);
        }
        public float GetRadius()
        {
            return C_radius;
        }
        public string GetBorderColor()
        {
            return C_bordercolor;
        }
        public string GetFillColor()
        {
            return C_fillcolor;
        }
    }
}
