using MovieList_LINQ.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieList_LINQ.Helpers
{
    public class JustChecking
    {
        public static void MoviesDontStartALith12PlusCharacters(List<MovieClass> movieList)
        {
            var checkingMovies = movieList
                                     .Where(movie => movie.Title.Length > 12);
            foreach (var item in checkingMovies)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                if (item.Title.ToCharArray()[0] != 'L')
                {
                    Console.WriteLine(item.Title);
                }
                Console.ResetColor();
            }
        }

        internal static void moviesDontStartALith12PlusCharacters(List<MovieClass> myMovies)
        {
            throw new NotImplementedException();
        }
    }
}
