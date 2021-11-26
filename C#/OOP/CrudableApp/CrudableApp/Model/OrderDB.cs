using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    class OrderDB:ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Order Data is Craeted");
        }

        public void Read()
        {
            Console.WriteLine("Order Data is Red");
        }

        public void Update()
        {
            Console.WriteLine("Order Data is Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Order Data is Deleted");
        }
    }
}
