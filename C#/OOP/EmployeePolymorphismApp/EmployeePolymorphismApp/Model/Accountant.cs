using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class Accountant:Employee
    {
        private double _Perks;
        public Accountant(int Empno, string name, float BasicSalary,string EmpPost) : base(Empno,name,BasicSalary, EmpPost)
        {
                
        }

        public override void Calculate()
        {
            _Perks = (double)30 / 100 *BasicSalary;
            Console.WriteLine("Perks Salary :{0}",_Perks);
        }
    }
}
