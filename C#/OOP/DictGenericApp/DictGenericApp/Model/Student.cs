using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictGenericApp.Model
{
    class Student
    {
        private int _rollNo;
        private int _standard;
        private string _name;
        private string _location;

        public Student(int rollNo, int standard,string name, string location)
        {
            this._rollNo = rollNo;
            this._standard = standard;
            this._name = name;
            this._location = location;
        }
        public override int GetHashCode()
        {
            string hasCode = Convert.ToString(_rollNo) + Convert.ToString(_standard);
            return int.Parse(hasCode);
        }
        public override bool Equals(object obj)
        {
            Student studentObj = (Student)obj;
            if (this._rollNo == studentObj._rollNo && this._standard == studentObj._standard) return true;
            return false;
        }
    }
}
