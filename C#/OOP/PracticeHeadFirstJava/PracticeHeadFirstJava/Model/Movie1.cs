using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHeadFirstJava.Model
{
    class Movie1
    {
        public string title;
        public string genre;
        public string language;
        public int rating;

        public void showIt()
        {
            Console.WriteLine("Showing the movie: " + title);
            Console.WriteLine("genre: " + genre);
            Console.WriteLine("Language: " + language);
            Console.WriteLine("Rating: " + rating);
        }

    }
}
