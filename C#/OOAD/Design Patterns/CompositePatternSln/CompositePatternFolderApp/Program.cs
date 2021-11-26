using CompositePatternFolderApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFolderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder moviefolder = new Folder("Movies");
            moviefolder.AddChild(new File("Bahubali", "1.5GB"));
            moviefolder.AddChild(new File("Anaconda", "2GB"));

            Folder patriotic = new Folder("Patriotic");
            moviefolder.AddChild(patriotic);
            patriotic.AddChild(new File("URI", "700MB"));

            moviefolder.Display();
            Console.ReadKey();
        }
    }
}
