using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogDoorApp.Model;
namespace DogDoorApp
{
    class DogDoorSimulator
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine("Tyson barks to go outside..... ");
            remote.PressButton();
            Console.WriteLine("\nTyson has gone outside..... ");
            remote.PressButton(); 
            Console.WriteLine("\nTyson's all done..... ");
            remote.PressButton(); 
            Console.WriteLine("\nTyson's back inside..... ");
            remote.PressButton();
            Console.ReadLine();
        }
    }
}
