using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPSolutionApp.Model;
namespace ISPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            var robot = new Robot();
            AtTheCafeteria(manager);
            AtTheWorkStation(manager);
            AtTheCafeteria(robot);
            AtTheWorkStation(robot);
            Console.ReadLine();
        }
        public static void AtTheCafeteria(IEatable eatable)
        {
            Console.WriteLine("At The Cafeteria :");
            eatable.StartEat();
            eatable.StopEat();
        }
        public static void AtTheWorkStation(IWorkable workable)
        {
            Console.WriteLine("AtTheWorkStation :");
            workable.StartWork();
            workable.StopWork();
        }

    }
}
