using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
     abstract class Employee
    {
        private int _Eno;
        private string _Ename;
        private float _BasicSalary;
        private string _Epost;

        public Employee(int Empno, string name,float BasicSalary, string EmpPost)
        {
            _Eno = Empno;
            _Ename = name;
            _BasicSalary = BasicSalary;
            _Epost = EmpPost;
        }
        public abstract void Calculate();
        public int EmplNo
        {
            get
            {
                return _Eno;
            }
        } 
        public string EmplName
        {
            get
            {
                return _Ename;
            }
        }
        public float BasicSalary
        {
            get
            {
                return _BasicSalary;
            }
        } 
        public string EmpPost 
        {
            get
            {
                return _Epost;
            }
        }
    }
}
