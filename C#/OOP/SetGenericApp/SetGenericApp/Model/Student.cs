using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGenericApp.Model
{
    class Student
    {
        private int _rollNo;
        private string _name;
        private string _location;

        public Student(int rollNo, string name, string location)
        {
            this._rollNo = rollNo;
            this._name = name;
            this._location = location;
        }
        public override int GetHashCode()
        {
            return _rollNo;
        }
        public override bool Equals(object obj)
        {
            Student studentObj = (Student)obj;
            if (this._rollNo == studentObj._rollNo) return true;
            return false;
        }
       
      
    }
}
