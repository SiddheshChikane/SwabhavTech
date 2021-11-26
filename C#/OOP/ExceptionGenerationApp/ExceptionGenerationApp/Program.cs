using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionGenerationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(args[0]);
            int secondNumber = Convert.ToInt32(args[1]);
            int result = firstNumber / secondNumber;
            Console.WriteLine("{0} / {1} = {2}", firstNumber,secondNumber,result);
            Main(args);
            Console.WriteLine("End of Main");
            Console.ReadKey();
        }
        //DivideByZeroException
        //Line No.15

        //FormatException
        //Line No. 13

        //OverflowException
        //Line No. 13

        //IndexOutOfRangeException
        //Line No.14
    }
}
