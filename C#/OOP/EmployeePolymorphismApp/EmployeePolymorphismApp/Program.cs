using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee M1 = new Manager(101, "Shivam", 25000, "Manager");
            SalarySlip(M1);
            M1.Calculate();
            Employee D1 = new Developer(102, "Akshay", 15000,"Developer");
            SalarySlip(D1);
            D1.Calculate();
            Employee A1 = new Accountant(103, "BhauSaheb", 10000,"Accountant");
            SalarySlip(A1);
            A1.Calculate();

            Console.ReadKey();
        }
        public static void SalarySlip(Employee emp)
        {
            Console.WriteLine("\n***********The Salary Slip**************\n");
            Console.WriteLine("Employee No.      : {0}",emp.EmplNo);
            Console.WriteLine("Employee Name.    : {0}",emp.EmplName);
            Console.WriteLine("Employee Salary.  : {0}",emp.BasicSalary);
            Console.WriteLine("Employee Post.    : {0}",emp.EmpPost);
           
        }
    }
}
