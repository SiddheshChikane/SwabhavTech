using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHeadFirstJava.Model
{
    class MovieTestHD
    {
        static void Main(string[] args)
        {
            Movie1 one = new Movie1();
            one.title = "Shershah";
            one.genre = "Sci Fi and Thriller";
            one.language = "Hindi";
            one.rating = 8;
            one.showIt();

            Movie1 two = new Movie1();
            two.title = "365 days";
            two.genre = "Romance";
            two.language = "Spanish";
            two.rating =6;
            two.showIt();

            Console.ReadKey();
        }
    }
}
