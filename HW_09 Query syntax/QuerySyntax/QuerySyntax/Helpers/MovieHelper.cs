using QuerySyntax.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuerySyntax.Helpers
{
    public class MovieHelper
    {
        public static List<Movie> AllMovies()
        {
            return new List<Movie>()
            {
                new Movie(){ Title= "The Sting", Year = 1973 , Rating = 8.3f, Duration = 119 },
                new Movie(){ Title = "Iron Mann", Year = 2008, Rating = 7.8f, Duration = 126 },
                new Movie(){ Title = "End Game", Year = 2018, Rating = 9.1f, Duration = 140 },
                new Movie(){ Title = "Space Force", Year = 2008, Rating = 8.2f, Duration = 150 },
                new Movie(){ Title = "What We Know So Far", Year = 2012, Rating = 7.7f, Duration = 106 },
                new Movie(){ Title = "Lovecraft Country", Year = 2013, Rating = 6.9f, Duration = 136 },
                new Movie(){ Title = "Parasite", Year = 2002, Rating = 8.9f, Duration = 96 },
                new Movie(){ Title = "Joker", Year = 1999, Rating = 5.2f, Duration = 86 },
                new Movie(){ Title = "The Platform", Year = 1998, Rating = 4.3f, Duration = 106 },
                new Movie(){ Title = "Knives Out", Year = 2008, Rating = 7.9f, Duration = 125 },
                new Movie(){ Title = "Last Man Standing", Year = 1996, Rating = 6.4f, Duration = 101 },

            };
        }
    }
}
