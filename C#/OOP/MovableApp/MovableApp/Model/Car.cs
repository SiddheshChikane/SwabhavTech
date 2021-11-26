using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableApp.Model
{
    class Car : Movable
    {
        public void Move()
        {
            Console.WriteLine("Car is Movable.");
        }
    }
}
