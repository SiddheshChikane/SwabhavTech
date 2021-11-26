using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircleEncapsulationApp;

namespace CircleEncapsulationApp.Model
{
    class CircleTest
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            Console.ReadKey();
        }
           

        private static void CaseStudy1()
        {
            Circle C1 = new Circle();
            
            C1.SetRadius(6.5f);
            C1.SetBorderColor("Yellow");
            C1.SetFillColor("blue");
            PrintDetails(C1);
            
        } 
        private static void CaseStudy2()
        {
            Console.WriteLine("Area of anonymous circle object is {0}", new Circle().CalcArea());
            Console.WriteLine("Radius of anonymous circle object is {0}", new Circle().GetRadius());
            Console.WriteLine("BorderColor of anonymous circle object is {0}", new Circle().GetBorderColor());
            Console.WriteLine("FillColor of anonymous circle object is {0}", new Circle().GetFillColor());
            Console.WriteLine(" ");
            PrintDetails(new Circle());
           
        }
        private static void CaseStudy3()
        {
            Circle c1 = new Circle();
            c1.SetRadius(8);
            c1.SetBorderColor("pink");
            c1.SetFillColor("grey");

            Circle[] manyCircles = new Circle[3];
            manyCircles[0] = c1;
            manyCircles[1] = new Circle();
            manyCircles[1].SetRadius(7);
            manyCircles[1].SetBorderColor("green");
            manyCircles[1].SetFillColor("violet");
            manyCircles[2] = new Circle();
            manyCircles[2].SetRadius(10);
            manyCircles[2].SetBorderColor("orange");
            manyCircles[2].SetFillColor("white");
            PrintDetails(manyCircles[0]);
            PrintDetails(manyCircles[1]);
            PrintDetails(manyCircles[2]);
           
        }
        private static void PrintDetails(Circle c)
        {
            float area = c.CalcArea();
            Console.WriteLine("radius is:{0} and border color is:{1} and fill color is:{2}", c.GetRadius(), c.GetBorderColor(), c.GetFillColor());
            Console.WriteLine("Area of Circle is: {0}", c.CalcArea());
            Console.WriteLine(" ");
           
        }

    }
}









