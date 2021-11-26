using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyUnitTestApp.Model
{
    class Program:Exception
    {
        static void Main(string[] args)
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                var types = assembly.GetTypes().Where(T => T.GetCustomAttributes<MyUnitTestClass>().Count() > 0);
                foreach (var T in types)
                {
                    Console.WriteLine(T.Name + " " + " ");
                    var methods = T.GetMethods().Where(m => m.GetCustomAttributes<MyUnitTestMethod>().Count() > 0);
                    Object A = Activator.CreateInstance(T);
                    Console.WriteLine("TestClasses  : {0}\n", methods.Count());

                    foreach (var m in methods)
                    {
                        NewMethod(A, m);
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }   

        private static void NewMethod(object A, MethodInfo m)
        {
            var W = m.Invoke(A, null);
            if (W.Equals(true))
            {
                Console.WriteLine("\t" + m.Name + " " + "........Passed");
            }
            else
            {
                Console.WriteLine("\t" + m.Name + " " + "........Failed");
                Console.WriteLine(" ");
            }
           
            
        }

    }   
}
