using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovableApp.Model;
namespace MovableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Movable[] m = new Movable[3];
            m[0] = new Car();
            m[1] = new Bike();
            m[2] = new Truck();
            StartRace(m);
            Console.ReadKey();
        }
        public static void StartRace(Movable[] m1)
        {
           foreach(Movable mov in m1)
            {
                mov.Move();
            }
        }
    }
}
