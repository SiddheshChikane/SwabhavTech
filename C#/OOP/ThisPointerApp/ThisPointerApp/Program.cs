using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisPointerApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Virat = new Player("Virat Kohli");
            PrintDetails(Virat);
            Player Sachin = new Player("Sachin Tendulkar", 45, GenderType.Male);
            PrintDetails(Sachin);
            Player elder = Sachin.WhoIsElder(Virat);
            PrintDetails(elder);
            Console.ReadKey();

        }
        private static void PrintDetails(Player p)
        {
            Console.WriteLine("Player Name : {0}",p.Name);
            Console.WriteLine("Player Age : {0}",p.Age);
            Console.WriteLine("Player Gender : {0}",p.Gender);
            Console.WriteLine(" ");
        }
    }
}
