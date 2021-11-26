using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOfListApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
           // CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
            Console.ReadKey();
        }

        private static void CaseStudy1()
        {
            ArrayList1 l = new ArrayList1();
            while (true)
            {
                Console.WriteLine("Enter y for entering in menu Or n for exiting from it: ");
                char yesOrNo = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("\n*****************List******************");
                    Console.WriteLine("1. Add ");
                    Console.WriteLine("2. Display ");
                    Console.WriteLine("3. Update ");
                    Console.WriteLine("4. Delete ");
                    Console.WriteLine("Enter Your Choice.");
                    int inp = Convert.ToInt32(Console.ReadLine());
                    switch (inp)
                    {
                        case 1:

                            Console.WriteLine("\nEnter The Input: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            l.AddToList(num);
                            Console.WriteLine(" ");
                            break;

                        case 2:

                            l.DisplayToList();
                            Console.WriteLine(" ");
                            break;

                        case 3:

                            int i = Convert.ToInt32(Console.ReadLine());
                            int n = Convert.ToInt32(Console.ReadLine());
                            l.UpdateToList(i, n);
                            break;

                        case 4:

                            int index = Convert.ToInt32(Console.ReadLine());
                            l.DeleteToList(index);
                            break;
                    }

                }
            }
        }
        private static void CaseStudy2()
        {
            Dictionary1 d = new Dictionary1();
            while (true)
            {
                Console.WriteLine("Enter y for entering in menu Or n for exiting from it: ");
                char yesOrNo = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("\n*****************List******************");
                    Console.WriteLine("1. Add ");
                    Console.WriteLine("2. Display ");
                    Console.WriteLine("3. Update ");
                    Console.WriteLine("4. Delete ");
                    Console.WriteLine("Enter Your Choice.");
                    int inp = Convert.ToInt32(Console.ReadLine());
                    switch (inp)
                    {
                        case 1:
                            Console.WriteLine("\nEnter The Input: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            int num2 = Convert.ToInt32(Console.ReadLine());
                            d.AddDict(num,num2);
                            Console.WriteLine(" ");
                            break;

                        case 2:
                            d.DisplayDict();
                            break;

                        case 3:
                            int i = Convert.ToInt32(Console.ReadLine());
                            int n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Add Key & Value ");
                            d.UpdateDict(i, n);
                            break;

                        case 4:
                            int index = Convert.ToInt32(Console.ReadLine());
                            d.DeleteDict(index);
                            break;
                    }

                }
            }
        }

        private static void CaseStudy3()
        {
            HashSet1 hashSet1 = new HashSet1();
            Console.WriteLine("HashSet");
            while (true)
            {
                Console.WriteLine("Enter y for entering in menu Or n for exiting from it: ");
                char yesOrNo = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("\n*****************List******************");
                    Console.WriteLine("1. Add ");
                    Console.WriteLine("2. Display ");
                    Console.WriteLine("3. Update ");
                    Console.WriteLine("4. Delete ");
                    Console.WriteLine("Enter Your Choice.");
                    int inp = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");
                    switch (inp)
                    {
                        case 1:
                            Console.WriteLine("\nEnter The Input: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            hashSet1.AddHash(num);
                            Console.WriteLine(" ");
                            break;

                        case 2:
                            hashSet1.DisplayHash();
                            break;

                        case 3:
                            Console.WriteLine("Enter old value : ");
                            int i = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new value : ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            hashSet1.UpdateHash(i, n);
                            break;

                        case 4:
                            int index = Convert.ToInt32(Console.ReadLine());
                            hashSet1.DeleteHash(index);
                            break;
                    }

                }
            }
        }
    }
}
