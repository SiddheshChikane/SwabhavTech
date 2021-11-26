using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class Manager:Employee
    {
        private double _HRA;
        private double _TA;
        private double _DA;
        public Manager(int Empno, string name, float BasicSalary, string EmpPost) : base(Empno, name, BasicSalary, EmpPost)
        {
                
        }
        public override void Calculate()
        {
            _HRA = (double)50 / 100 * BasicSalary;
            _TA = (double)40 / 100 * BasicSalary;
            _DA = (double)30 / 100 * BasicSalary;
            Console.WriteLine("HRA  :{0}",_HRA);
            Console.WriteLine("TA   :{0}",_TA);
            Console.WriteLine("DT   :{0}",_DA);
            Console.WriteLine(" ");
        }
    }
}
