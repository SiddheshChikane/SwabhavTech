using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp.Model
{
    class Robot:IWorker
    {
        public void StartWork()
        {
            Console.WriteLine("Robot is Start Working...");
        }
        public void StopWork()
        {
            Console.WriteLine("Robot is Stop Working...");
        }
        public void StartEat()
        {
            throw new Exception("Robots Can Eat..");
        } 
        public void StopEat()
        {
            throw new Exception("Robots Can Eat..");
        }
        
    }
}
