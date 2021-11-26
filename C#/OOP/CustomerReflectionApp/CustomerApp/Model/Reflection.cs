using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Model
{
    class Reflection
    {
        public void DoReflection(Account a)
        {
            Type r = a.GetType();
            PropertyInfo[] property = r.GetProperties();
            ConstructorInfo[] constructor = r.GetConstructors();
            MethodInfo[] methods= r.GetMethods();
            MemberInfo[] members= r.GetMembers();

            Console.WriteLine("Total Constructors are : {0}", constructor.Length);
            for(int i = 0; i < constructor.Length; i++)
            {
                Console.WriteLine(constructor[i]);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Total Properties  are : {0}", property.Length);
            for(int i = 0; i < property.Length; i++)
            {
                Console.WriteLine(property[i]);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Total Methods  are : {0}", methods.Length);
            for(int i = 0; i < methods.Length; i++)
            {
                Console.WriteLine(methods[i]);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Total Members  are : {0}", members.Length);
            for(int i = 0; i < members.Length; i++)
            {
                Console.WriteLine(members[i]);
            }
            Console.WriteLine(" ");
        }
    }
}
