using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AurionProMathCalculator;
namespace ConsoleAurionProMathCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            CaseStudy1(model);
            CaseStudy2(model);
            CaseStudy3(model);
            Console.ReadKey();

        }
        private static void CaseStudy1(Model model)
        {
            if(model.CheckPrimeNo(23) == true)
            {
                Console.WriteLine("The number will be Prime.");
            }
            else
            {
                Console.WriteLine("The number will be not Prime.");
            }
        }
        private static void CaseStudy2(Model model)
        {
            int limit = 90;
            int[] evenArray = model.GenerateEvenNo(limit);
            Console.WriteLine("Even No till {0}",limit);
            foreach(int i in evenArray)
            { 
                Console.Write(i +" ");
            }
            Console.WriteLine(" ");
        }
        private static void CaseStudy3(Model model)
        {
            int limit = 30;
            int[] primeArray = model.GeneratePrimeNo(limit);
            Console.WriteLine("Prime No till {0}",limit);
            foreach (int i in primeArray)
            {
                if (i == 0)
                {
                    break;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine(" ");
        }

    }
}
