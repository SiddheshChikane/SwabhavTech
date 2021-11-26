using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            SalariedEmp p1 = new Professor(101, "Mumbai", "10/03/1999", 50000);
            SalariedEmp p2 = new Professor(102, "Satara", "18/07/1999", 80000);
            Student s1 = new Student(103, "Nagpur", "23/04/1998", "CSE");
            Student s2 = new Student(104, "Goa", "13/08/1999", "CIVIL");
            PrintDetails(p1);
            PrintDetails(p2);
            PrintDetails(s1);
            PrintDetails(s2);
            Console.ReadKey();
        }
        public static void PrintDetails(SalariedEmp p)
        { 
            Console.WriteLine("\nId               : " + p.id);
            Console.WriteLine("Location           : " + p.address);
            Console.WriteLine("date of birth      : " + p.dateofbirth);
            Console.WriteLine("Basic Salary       : " + p.Basicsalary);
            Console.WriteLine("Salary with Bonus  : " + p.CalcSalary());
            Console.WriteLine(" ");
        }
        public static void PrintDetails(Student s)
        {
            Console.WriteLine("\nId               : " + s.id);
            Console.WriteLine("Location           : " + s.address);
            Console.WriteLine("Date of Birth      : " + s.DateOfBirth);
            Console.WriteLine("Branch of Student  : " + s.Branch);
            Console.WriteLine(" ");
        }
    }
}
    

