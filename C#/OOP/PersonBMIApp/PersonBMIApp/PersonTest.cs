using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonBMIApp.Model
{
    class PersonTest
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
            Console.ReadKey();
            
        }
        public static void CaseStudy1()
        {
            Person p1 = new Person("Siddhesh", 22, 5.8f, 52f, "Male");
            PrintDetails(p1);
            p1.PersonWorkout();
            PrintDetails(p1);
            p1.PersonEat();
            PrintDetails(p1);
        }
        private static void CaseStudy2()
        {
            Person[] otherPerson = new Person[3];
            Person p1 = new Person("Akshay", 22, 70f, 75f, "Male");
            Person p2 = new Person("Shivam", 23, 75f, 70f, "Male");
            Person p3 = new Person("Siddhesh", 22, 60f, 73f, "Male");
            otherPerson[0] = p1;
            otherPerson[1] = p2;
            otherPerson[2] = p3;

            p1.PersonEat();
            p1.BMI();
            ShowBMI(p1);
            PrintDetails(otherPerson [0]);

            p2.PersonWorkout();
            p2.BMI();
            ShowBMI(p2);
            PrintDetails(otherPerson[1]);

            p3.PersonWorkout();
            p3.BMI();
            ShowBMI(p3);
            PrintDetails(otherPerson[2]);
        }
        private static void PrintDetails(Person p)
        {
            Console.WriteLine("Name   : {0}", p.GetName());
            Console.WriteLine("Age    : {0}", p.GetAge());
            Console.WriteLine("Height : {0}", p.GetHeight());
            Console.WriteLine("Weight : {0}", p.GetWeight());
            Console.WriteLine("Gender : {0}", p.GetGender());
            
            
            if(p.GetBMI() < 20)
            {
                Console.WriteLine("Person is Underweight");
                Console.WriteLine(" ");
            }
            else if (p.GetBMI() >=20 && p.GetBMI() <=25)
            {
                Console.WriteLine("Person is Fit");
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("Person is Overweight");
                Console.WriteLine(" ");
            }
        }
        public static void ShowBMI(Person p)
        {
            Console.WriteLine("BMI    : {0}",p.GetBMI());
            Console.WriteLine(" ");
        }
    }
}
