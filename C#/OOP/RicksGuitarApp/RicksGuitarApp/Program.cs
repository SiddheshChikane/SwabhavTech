using RicksGuitarApp.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RicksGuitarApp.Model;

namespace RicksGuitarApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            Guitar whatErinLikes = new Guitar("", 0, Builder.ANY, "model2",GType.ELECTRIC,Wood.ALDER,Wood.ALDER);

            List<Guitar> guitar = inventory.search(whatErinLikes);

            if (guitar != null)
            {
                PrintDetails(guitar);
            }
            else
            {
                Console.WriteLine("Sorry Erin, We have nothing for you");
            }

            Console.ReadLine();
        }

        private static void PrintDetails(List<Guitar> guitarList)
        {
            Console.WriteLine("==============================Match Guitars==================================");
            Console.WriteLine("Erin, you might like this \n");
            foreach (Guitar guitar in guitarList)
            {
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(guitar.GetBuilder +" " + guitar.GetModel + " " + guitar.Type + " guitar :");
                Console.WriteLine(guitar.GetBackWood + " back and sides");
                Console.WriteLine(guitar.GetTopWood + " top.");
                Console.WriteLine("You can have it for only $" + guitar.GetPrice + "! \n");
            }

        }

        private static void PrintGuitarDetails(Inventory inventry1)
        {
            Guitar guitar = inventry1.GetGuitar("S001");
            Console.WriteLine("searched element of seriel id {0}", guitar.GetSerialNumber);


            Console.WriteLine(guitar.GetSerialNumber);
            Console.WriteLine(guitar.GetModel);
            Console.WriteLine(guitar.Type);
            Console.WriteLine(guitar.GetTopWood);
            Console.WriteLine(guitar.GetBackWood);
            Console.WriteLine(guitar.GetPrice);

        }

        private static void initializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("S001", 2500, Builder.OLSON, "model1", GType.ACOUSTIC, Wood.BRAZILIAN_ROSEWOOD, Wood.COCOBOLO);
            inventory.AddGuitar("S004", 2500, Builder.MARTIN, "model2", GType.ACOUSTIC, Wood.BRAZILIAN_ROSEWOOD, Wood.COCOBOLO);
            inventory.AddGuitar("S002", 3000, Builder.FENDER, "model2", GType.ELECTRIC, Wood.CEDAR, Wood.CEDAR);
            inventory.AddGuitar("S003", 2600, Builder.FENDER, "model3", GType.ELECTRIC, Wood.ALDER, Wood.ALDER);
        }
    }
}
        
    

