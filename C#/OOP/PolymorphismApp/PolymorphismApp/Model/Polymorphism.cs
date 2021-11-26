using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp.Model
{
    class Polymorphism
    {
       public void Show(string str)
        {
            Console.WriteLine(" String Value is : {0}",str);
        }
        public void Show(int value)
        {
            Console.WriteLine(" Int Value is : {0}", value);
        }
        public void Show(double value)
        {
            Console.WriteLine(" Double Value is : {0}", value);
        } 
        public void Show(float value)
        {
            Console.WriteLine(" Double Value is : {0}", value);
        } 
        public void Show(bool value)
        {
            Console.WriteLine(" Bool Value is : {0}", value);
        }
        public void Show(char value)
        {
            Console.WriteLine(" Char Value is : {0}", value);
        }
    }
       
    
}
