using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonBMIApp.Model
{
    class Person
    {
        private string _pname;
        private int _age;
        private float _height;
        private float _weight;
        private string _gender;
        private float _bmi;
        public Person(string name, int age, float height,float weight,string gender)
        {
            _pname = name;
            _age = age;
            _height = height * 0.0254f;
            _weight = weight;
            _gender = gender;
        }
        public void PersonWorkout()
        {
            _weight = _weight - (10 * _weight) / 100;
            Console.WriteLine("Workout has been started....");
            Console.WriteLine("Weight of person has been reduced by 10%");
           
        }
        public void PersonEat()
        {
            _weight = _weight + (5 * _weight) / 100;
            _height = _height + (2 * _height) / 100;
            Console.WriteLine("Its Eating time...");
            Console.WriteLine("Weight of person has been increased by 5 % ");
            Console.WriteLine("Height of person has been increased by 2 % ");
        }
        public void BMI()
        {
            _bmi = _weight / (_height * _height);
        }
        public string GetName()
        {
            return _pname;
        }
        public int GetAge()
        {
            return _age;
        }
        public float GetHeight()
        {
            return _height;
        }
        public float GetWeight()
        {
            return _weight;
        }
        public string GetGender()
        {
            return _gender;
        }
        public float GetBMI()
        {
            return _bmi;
        }


    }

}
