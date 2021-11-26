using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp.Model
{
    class Manager:IEatableWorkable
    {
        public void StartWork()
        {
            Console.WriteLine("Manager is Start Working...");
        }
        public void StopWork()
        {
            Console.WriteLine("Manager is Stop Working...");
        }
        public void StartEat()
        {
            Console.WriteLine("Manager is Start Eating...");
        }
        public void StopEat()
        {
            Console.WriteLine("Manager is Stop Eating...");
        }
    }
}
