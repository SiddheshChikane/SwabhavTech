using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnitTestApp.Model
{
    [AttributeUsage(AttributeTargets.All)]
    class MyUnitTestClass:Attribute
    {
        public string Name { get; set; }
    }
}
