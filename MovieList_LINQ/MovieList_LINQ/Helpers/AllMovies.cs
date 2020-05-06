using MovieList_LINQ.Movie;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList_LINQ.Helpers
{
    public class AllMovies : MovieClass
    {
        public static List<MovieClass> AllMoviesHere()
        {
            return new List<MovieClass>()
            {
                new MovieClass(){ Title= "The Sting", Year = 1973 , Rating = 8.3f, Duration = 119 },
                new MovieClass(){ Title = "Iron Man", Year = 2008, Rating = 7.8f, Duration = 126 },
                new MovieClass(){ Title = "End Gamee", Year = 2018, Rating = 9.1f, Duration = 140 },
                new MovieClass(){ Title = "Space Force", Year = 2008, Rating = 8.2f, Duration = 150 },
                new MovieClass(){ Title = "What We Know So Far", Year = 2012, Rating = 7.7f, Duration = 106 },
                new MovieClass(){ Title = "Lovecraft Country", Year = 2013, Rating = 6.9f, Duration = 136 },
                new MovieClass(){ Title = "Parasite", Year = 2002, Rating = 8.9f, Duration = 96 },
                new MovieClass(){ Title = "Joker", Year = 1999, Rating = 5.2f, Duration = 86 },
                new MovieClass(){ Title = "The Platform", Year = 1998, Rating = 4.3f, Duration = 106 },
                new MovieClass(){ Title = "Knives Out", Year = 2008, Rating = 7.9f, Duration = 125 },
                new MovieClass(){ Title = "Last Man Standing", Year = 1996, Rating = 6.4f, Duration = 101 },

            };
        }
    }
}
