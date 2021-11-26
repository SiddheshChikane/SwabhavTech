using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCallStackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                M1();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                _ = Console.ForegroundColor - ConsoleColor.Blue;
                Console.WriteLine(e.StackTrace);
            }

           
            Console.WriteLine("End of main");
            Console.ReadKey();

        }

        private static void M1()
        {
            Console.WriteLine("Inside M1");
            M2();
        }

        public static void M2()
        {
            Console.WriteLine("Inside M2");
            M3();
        }
        public static void M3()
        {
            Console.WriteLine("Inside M3");
            throw new Exception("Something Went Wrong in M3");
                
        }
    }
}
