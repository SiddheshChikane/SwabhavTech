using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy();
        }

        private static void CaseStudy()
        {
            Todo T = new Todo();
            while (true)
            {
                Console.WriteLine("Enter y for ToDo List and n for Exit :");
                char YesOrNo = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    if (YesOrNo == 'y')
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("1.Display  2.Add  3.Exit ");
                        int options = Convert.ToInt32(Console.ReadLine());
                        switch (options)
                        {
                            case 1:
                                T.Display();
                                break;
                            case 2:
                                Console.WriteLine("Enter the task :");
                                string task = Convert.ToString(Console.ReadLine());
                                T.AddToList(task);
                                break;
                            case 3:
                                
                                T.Exit();
                                break;
                        }
                    }
                    else if (YesOrNo == 'n')
                    {
                        T.Exit();
                    }
                }
            }
        }
    }
}
