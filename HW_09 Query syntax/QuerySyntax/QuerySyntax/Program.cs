using QuerySyntax.Entities;
using QuerySyntax.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuerySyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            var myMovies = MovieHelper.AllMovies();

            Console.WriteLine(@"1. Find all movies that their titles starts with ""L""");
            var startWithL = (from movie in myMovies
                              where movie.Title.StartsWith('L')
                              select movie.Title).ToList();
            startWithL.ForEach(m => Console.WriteLine(@$"""{m}"""));
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("2. Find the NUMBER of movies that have rating higher than 7.5");
            var moviesRating7point5plus = (from movie in myMovies
                                           where movie.Rating > 7.5
                                           select movie)
                                           .ToList();
            Console.WriteLine($"Movies with rating higher than 7.5 are: {moviesRating7point5plus.Count} movies.");
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("3. Find all movies TITLES with year of production before 2005");
            var moviesProductBefore2005 = (from movie in myMovies
                                           where movie.Year < 2005
                                           select movie).ToList();
            moviesProductBefore2005.ForEach(m => Console.WriteLine(m.Title));
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("4. Find all movies TITLES and RATING that have rating higher then 8.0");
            var moviesRatingHigher8 = (from movie in myMovies
                                       where movie.Rating > 8
                                       select new { movie.Title, movie.Rating })
                                           .ToList();
            moviesRatingHigher8.ForEach(m => Console.WriteLine($@"""{m.Title}"" - {m.Rating} rating."));
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("5. Find first 5 movies that have duration time longer then 2 hours");
            var first5MoviesDuration2HoursPlus = (from movie in myMovies
                                                  where movie.Duration > 120
                                                  select movie).Take(5)
                                                  .ToList();
            first5MoviesDuration2HoursPlus.ForEach(m => Console.WriteLine(@$"""{m.Title}"" - {m.Duration} min."));
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("6. Find last 3 movies TITLES and DURATION that have duration less then 2 hours");
            var firlast3MoviesLess120 = (from movie in myMovies
                                         where movie.Duration < 120
                                         select movie).TakeLast(3)
                                                  .ToList();
            firlast3MoviesLess120.ForEach(m => Console.WriteLine($"{m.Title} - {m.Duration} min."));
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("7. Find all movies TITLES and RATING and order them by DURATION (DESC)");
            var moviesDescendingOrderDuration = (from movie in myMovies
                                                 .OrderByDescending(m => m.Duration)
                                                 select movie)
                                                  .ToList();
            moviesDescendingOrderDuration.ForEach(m => Console.WriteLine(@$"""{m.Title}"" - {m.Duration} min."));
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("8. Find all movies with TITLES that don't start with L and TITLES include more than 7 characters");
            var moviesNoA7PlusChar = (from movie in myMovies
                                      where movie.Title.ToCharArray()[0] != 'L'
                                      where movie.Title.ToCharArray().Length > 12
                                      select movie)
                                      .ToList();
            moviesNoA7PlusChar.ForEach(m => Console.WriteLine(@$"Dont start with 'L' & 7 char more: ""{m.Title}""."));
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("9. Find all movies RATINGS that have RATINGS higher than 7.2, DURATIONS less then 1hour and 50min ");
            var moviesRating7point2less110min = (from movie in myMovies
                                                 where movie.Duration < 110 && movie.Rating > 7.2
                                                 select movie)
                                                 .ToList();
            moviesRating7point2less110min.ForEach(m => Console.WriteLine(@$"Rating hifher than 7.2 & less 110 min: ""{m.Title}""."));
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("10. Find all movies TITLES and RATINGS that have TITLES with less than 10 characters, DURATION" +
                "longer than 2 hours, RATING higher then 6.7 and order them by TITLE(ASC)");
            var moviesLastTask = ((from movie in myMovies
                                  where movie.Title.Replace(" ", "").ToCharArray().Length < 10
                                  where movie.Duration > 120
                                  where movie.Rating > 6.7
                                  select movie)
                                  .OrderBy(movie => movie.Title))
                                 .ToList();
            moviesLastTask.ForEach(m => Console.WriteLine(@$"Rating hifher than 6.7 & longer than 2 hours (less 10 char): ""{m.Title}""."));
            Console.WriteLine("----------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
