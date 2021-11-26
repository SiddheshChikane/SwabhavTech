using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList My_array = new ArrayList();

            My_array.Add(12.56);
            My_array.Add("ArrayList");
            My_array.Add(null);
            My_array.Add('A');
            My_array.Add(1234);
           
     
            foreach (var elements in My_array)
            {
                Console.WriteLine(elements);
            }
            Console.ReadKey();
        }
    }
}
