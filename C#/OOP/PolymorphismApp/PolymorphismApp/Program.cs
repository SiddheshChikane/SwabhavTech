using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp.Model
{
    class MonsterTestDrive
    {
        static void Main(string[] args)
        {
            Polymorphism p = new Polymorphism();
            p.Show("This is Polymorphism...");
            p.Show(123);
            p.Show(456.23456);
            p.Show(23.32f);
            p.Show(false);
            p.Show('S');
        }
    }
}