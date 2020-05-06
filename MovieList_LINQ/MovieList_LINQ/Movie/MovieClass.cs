using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieList_LINQ.Movie
{
    public class MovieClass
    {
        public MovieClass()
        {

        }
        public string Title { get; set; }
        public float Rating { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }

        //public static void moviesDontStartAWith7PlusCharacters(List<MovieClass> mmmm) {
        //    var moviesDontStartAWith7PlusChar = mmmm
        //                                            .Where(movie => movie.Title.Length > 15);
        //    foreach (var item in moviesDontStartAWith7PlusChar)
        //    {
        //        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        //        Console.WriteLine(item.Title);
        //        Console.ResetColor();
        //    }
        //}

    }
}
