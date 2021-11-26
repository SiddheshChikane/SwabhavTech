using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Model
{
    class ProductDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Product Data is Created");
        }

        public void Read()
        {
            Console.WriteLine("Product Data is Red");
        }

        public void Update()
        {
            Console.WriteLine("Product Data is Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Product Data is Deleted");
        }
    }
}
