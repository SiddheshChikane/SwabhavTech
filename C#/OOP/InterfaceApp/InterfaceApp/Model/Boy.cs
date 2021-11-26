using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp.Model
{
    class Boy : IEmotion, IManner
    {
        public void Cry()
        {
            Console.WriteLine("Boy is Crying.");
        }

        public void Depart()
        {
            Console.WriteLine("Boy is Departing.Good Bye");
        }

        public void Laugh()
        {
            Console.WriteLine("Boy is Laughing");
        }
    

        public void Wish()
        {
         Console.WriteLine("Wish you Good Luck.");
        
        }
    }
}
