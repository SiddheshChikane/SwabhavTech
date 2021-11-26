using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictGenericApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
            Console.ReadKey();
        }
        public static void CaseStudy1()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "One");
           //map.Add(1, "ONE");
            map.Add(2, "Two");

            Console.WriteLine("Count : {0}",map.Count()) ;

            foreach(KeyValuePair<int,string> item in map)
            {
                Console.WriteLine("Key :{0} & Value : {1}",item.Key,item.Value );
            }
        }
        public static void CaseStudy2()
        {
            var map = new Dictionary<Student, Student>();

            var s1 = new Student(12, 10, "Sid", "Koparkhairane");
            var s2 = new Student(10, 12, "Akshay", "Thane");
            var s3 = new Student(12, 10, "Shivam", "Sion");

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());

            map.Add(s1, s1);
            map.Add(s2, s2);
            bool result = !map.ContainsKey(s3);
            if (result)
            {
                map.Add(s3, s3);
            }
            Console.WriteLine(map.Count());
        }
    }
}
