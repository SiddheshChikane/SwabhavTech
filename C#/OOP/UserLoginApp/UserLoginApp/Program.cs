using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            SecurityService secure = new SecurityService();
            secure.AddUser("1001", "Siddhesh", "Chikane", "siddheshchikane17@gmail.com", "959473");
            secure.AddUser("1002", "Siddhesh", "Chikane", "siddheshchikane17@gmail.com", "4545");
            secure.Login("1002", "4545");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
