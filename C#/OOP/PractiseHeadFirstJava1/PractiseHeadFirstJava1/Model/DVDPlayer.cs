using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseHeadFirstJava1.Model
{
    class DVDPlayer
    {
        public bool DVDcanRecord = false;

        public void recDVD()
        {
            Console.WriteLine("DVD Recording Successfully..");        
        }
        public void playDVD()
        {
            Console.WriteLine("DVD Playing Successfully..");
        }
    }
}
