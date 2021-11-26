using System;

namespace OverLoadingApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            PrintDetails(100);
            PrintDetails("Hello");
            PrintDetails(100.55);
            PrintDetails(100.55f);
            PrintDetails(true);
            PrintDetails('#');
            Console.ReadKey();
        }
        public static void PrintDetails(int content)
        {
            Console.WriteLine("Overload #1 : integer");
            Console.WriteLine(content);
        }
        public static void PrintDetails(string content)
        {
            Console.WriteLine("Overload #2 : String");
            Console.WriteLine(content);
        }
        public static void PrintDetails(double content)
        {
            Console.WriteLine("Overload #3 : Double");
            Console.WriteLine(content);
        }
        public static void PrintDetails(float content)
        {
            Console.WriteLine("Overload #4 : float");
            Console.WriteLine(content);
        }
        public static void PrintDetails(bool content)
        {
            Console.WriteLine("Overload #5 : bool");
            Console.WriteLine(content);
        }
        public static void PrintDetails(char content)
        {
            Console.WriteLine("Overload #6 : char");
            Console.WriteLine(content);
        }
    }
}
