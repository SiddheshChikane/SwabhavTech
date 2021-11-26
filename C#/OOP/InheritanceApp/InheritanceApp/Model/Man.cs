using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    class Man
    {
        public virtual void Jump()
        {
            Console.WriteLine("Boy is Jumping");
        }
        public void Read()
        {
            Console.WriteLine("Man is Reading");
        } 
        public void Walk()
        {
            Console.WriteLine("Man is Walking");
        }public void Play()
        {
            Console.WriteLine("Man is Playing");
        }
    }
}
