using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringApp.Model
{
    abstract class SalariedEmp:Person
    {
            private double _basicSalary;

            public SalariedEmp(int id, string address, string dateofbirth, double basicsalary) : 
            base(id, address, dateofbirth, basicsalary)
            {

                _basicSalary = basicsalary;
            }

            public abstract double CalcSalary();


        
    }
}
