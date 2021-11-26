using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricGuitar.Model
{
    class ElectricGuitarTest
    {
        public static void Main(string[] args)
        {
            EGuitar g = new EGuitar();
            g.SetBrand("Fender");
            Console.WriteLine(g.GetBrand());
            g.SetNumOfPickups(2);
            Console.WriteLine(g.GetNumOfPickups());
            g.SetIsPopstarUsesIt(true);
            Console.WriteLine(g.GetIsPopstarUsesIt());

            Console.ReadKey();

        }
    }
}
