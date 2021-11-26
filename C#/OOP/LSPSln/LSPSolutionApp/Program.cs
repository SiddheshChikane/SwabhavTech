using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPSolutionApp.Model;
namespace LSPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle :");
            ShouldNotChangeWidthIfHeightIsModified(new Rectangle(20, 30));
            Console.ReadLine();
        }
        public static void ShouldNotChangeWidthIfHeightIsModified(Rectangle rectangle)
        {
            var before = rectangle.Width;
            rectangle.Height = rectangle.Height + 10;
            var after = rectangle.Width;
            Console.WriteLine(before == after);
            Console.WriteLine("Before Width : " + before);
            Console.WriteLine("Before Height : " + after);

        }
    
    }
}
