using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    public abstract class CustomerDB:ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Customer Data is Created");
        }

        public abstract void Delete();


        public void Read()
        {
            Console.WriteLine("Customer Data is Red");
        }

        public abstract void Update();
        
    }
}
