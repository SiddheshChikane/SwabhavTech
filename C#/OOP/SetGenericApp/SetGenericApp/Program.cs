using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGenericApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
            Console.ReadLine();
        }
        public static void CaseStudy1()
        {
            HashSet<int> numbers = new HashSet<int>();
            numbers.Add(23);
            numbers.Add(500);
            numbers.Add(6);
            numbers.Add(6);
            numbers.Add(1000);

            Console.WriteLine("Total Numbers  :{0}",numbers.Count());

            foreach(int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        public static void CaseStudy2()
        {
            Student s1 = new Student(101, "Sid", "KoparKhairane");
            Student s2 = new Student(101, "Sid", "KoparKhairane");
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());

            HashSet<Student> students = new HashSet<Student>();
            students.Add(s1);
            students.Add(s2);
            Console.WriteLine(students.Count());
           
        }
    }
}
