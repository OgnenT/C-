using MovieList_LINQ.Helpers;
using MovieList_LINQ.Movie;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieList_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var myMovies = AllMovies.AllMoviesHere();

            // 1. Find all movies that their titles starts with "L"
            var startsWithL = myMovies
                                    .Where(movie => movie.Title.StartsWith('L'))
                                    .Select(movie => movie.Title)
                                    .ToList();

            foreach (var item in startsWithL)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Movies - starts with 'L': '{item}';");
                Console.ResetColor();
            }

            // 2. Find the NUMBER of movies that have rating higher than 7.5
            var movieHigher7point5 = myMovies.Where(movie => movie.Rating > 7.5f).ToList();
            Console.WriteLine($"There are {movieHigher7point5.Count} movies with rating more than 7.5!!");

            // 3. Find all movies TITLES with year of production before 2005
            var yearProduc2005 = myMovies
                .Where(movie => movie.Year > 2005)
                .Select(movie => new { movie.Title, movie.Year })
                .ToList();
            foreach (var item in yearProduc2005)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Movie after 2005: '{item.Title}' year/{item.Year};");
                Console.ResetColor();
            }

            // 4. Find all movies TITLES and RATING that have rating higher then 8.0
            var moviesWithRating8Plus = myMovies.Where(movie => movie.Rating >= 8).ToList();
            foreach (var item in moviesWithRating8Plus)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Rating higher than 8: '{item.Title}' with rating {item.Rating};");
                Console.ResetColor();
            }

            // 5. Find first 5 movies that have duration time longer then 2 hours
            var fiveMoviesLongerThan2Hours = myMovies
                                                    .Where(movie => movie.Duration > 120)
                                                    .Take(5).ToList();
            foreach (var item in fiveMoviesLongerThan2Hours)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"First five movies longer than 2 hours: '{item.Title}';");
                Console.ResetColor();
            }

            // 6. Find last 3 movies TITLES and DURATION that have duration less then 2 hours
            var threeMoviesLessThan2Hours = myMovies
                                                    .Where(movie => movie.Duration < 120)
                                                    .TakeLast(3).ToList();
            foreach (var item in threeMoviesLessThan2Hours)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Last three movies less than 2 hours: '{item.Title}' - {item.Duration} min.");
                Console.ResetColor();
            }

            // 7. Find all movies TITLES and RATING and order them by DURATION (DESC) - no condition needed
            var orderedMovies = myMovies
                                        .Select(movie => new { movie.Title, movie.Duration, movie.Rating })
                                        .OrderByDescending(movie => movie.Duration)
                                        .ToList();
            for (int i = 0; i < orderedMovies.Count; i++)
            {
                Console.WriteLine($" {i + 1}. '{orderedMovies[i].Title}', duration: {orderedMovies[i].Duration}" +
                    $" & raiting: {orderedMovies[i].Rating}");
            }

            // 8. Find all movies with TITLES that don't start with L and TITLES include more than 10 characters
            JustChecking.MoviesDontStartALith12PlusCharacters(myMovies);

            // 9. Find all movies RATINGS that have RATINGS higher than 7.2, DURATIONS less then 1hour and 50min
            var moviesRating7point2Less110Min = myMovies
                                                    .Where(movies => movies.Rating > 7.2f && movies.Duration < 110)
                                                    .Select(movies => movies.Title)
                                                    .ToList();
            foreach (var item in moviesRating7point2Less110Min)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Raiting higher 7.2 & less than 110 minutes: '{item}'");
                Console.ResetColor();
            }

            // 10. Find all movies TITLES and RATINGS that have TITLES with less than 10 characters, DURATION
            // longer than 2 hours, RATING higher then 6.7 and order them by TITLE(ASC)
            var movieBullShit = myMovies
                                    .Where(movie => movie.Title.Replace(" ", "").Length < 10)
                                    .Where(movie => movie.Duration > 120)
                                    .Where(movie => movie.Rating > 6.7f)
                                    .OrderBy(movie => movie.Rating)
                                    .Select(movie => new { movie.Title, movie.Rating })
                                    .ToList();
            Console.WriteLine("All Movies 10 less characters, longer than 2 hours, rating higher than 6.7 ascending:");
            foreach (var item in movieBullShit)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(item.Title + " " + item.Rating);
                Console.ResetColor();
            }


            Console.ReadLine();
        }
    }
}
