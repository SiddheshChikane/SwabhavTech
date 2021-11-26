using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseHeadFirstJava1.Model
{
    class DVDPlayerTestDrive
    {
        public static void Main(string[] args)
        {
            DVDPlayer d = new DVDPlayer();
            d.DVDcanRecord = true;
            d.playDVD();
            if (d.DVDcanRecord == true)
            {
                d.recDVD();
            }
            Console.ReadKey();
        }
    }
}
