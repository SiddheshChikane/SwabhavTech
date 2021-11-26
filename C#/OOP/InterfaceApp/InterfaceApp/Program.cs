using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceApp.Model;
namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Man x = new Man();
            Boy y = new Boy();

            AtThePartyHall(x);
            AtThePartyHall(y);
            //AtTheCinemaHall(x);
            AtTheCinemaHall(y);
            Console.ReadKey();
        }
        static void AtThePartyHall(IManner obj)
        {
            Console.WriteLine("At The Party.");
            obj.Wish();
            obj.Depart();
        }
        static void AtTheCinemaHall(IEmotion obj)
        {
            Console.WriteLine("At The Cinema Hall.");
            obj.Cry();
            obj.Laugh();
        }

    }
}
