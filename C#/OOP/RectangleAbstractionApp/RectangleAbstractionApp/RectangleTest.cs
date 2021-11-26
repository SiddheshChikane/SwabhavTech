using RectangleAbstractionApp.Model;
using System;


namespace RectangleAbstractionApp
{
    class RectangleTest
    {
        public static void Main(string[] args)
        {
            Rectangle small;
            Rectangle big;
            
            small = new Rectangle();
            big = new Rectangle();
           
            small.height = 6;
            small.width = 10;
            big.height = 6;
            big.width = 120;
            Rectangle temp = small;
            Console.WriteLine(temp.width);
            Console.WriteLine(small.width);
            temp.width += 7;
            Console.WriteLine(temp.width);
            Console.WriteLine(small.width);
            int area = small.CalculateArea();
            Console.WriteLine("big rectangle"+" width = "+small.width+" height = "+ small.height+ "and"+"area = "+area);
            int area1 = big.CalculateArea();
            Console.WriteLine("big rectangle"+" width="+big.width+" height= "+ big.height+ "and"+"area= "+area1);
            Console.WriteLine(temp.width);
            Console.WriteLine(small.width);
            Console.WriteLine(small.GetHashCode());
            Console.WriteLine(big.GetHashCode());
            Console.WriteLine(temp.GetHashCode());
    
            Console.ReadKey();


        }
    }
}



