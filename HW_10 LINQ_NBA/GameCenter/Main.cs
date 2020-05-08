using System;
using System.Collections.Generic;
using System.Linq;
using TeamSource.Enteties;
using TeamSource.Helpers;

namespace GameCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = TeamsDataBase.GetAllTeams();

            // Find all TEAMS with names starting with LA
            var teamsStartingWithLA = teams.Where(team => team.Name.StartsWith("LA")).ToList();
            // teamsStartingWithLA.ForEach(team => Console.WriteLine(team.Name));


            // Find all team NAMES which are playing in "Staples Center"
            var teamsPlayingInStaplesCenter = teams.Where(team => team.Arena.Equals("Staples Center"))
                                                      .Select(team => team.Name).ToList();
            // teamsPlayingInStaplesCenter.ForEach(team => Console.WriteLine(team));



            // Find all teams coaches
            var allCoaches = teams.Select(team => team.Coach).ToList();
            //allCoaches.ForEach(coach => Console.WriteLine(coach.FullName));



            // Find 3 oldest coaches NAMES
            var oldest3CoahcesNames = allCoaches.OrderByDescending(coach => coach.Age)
                                                          .Take(3)
                                                            .Select(coach => coach.FullName)
                                                              .ToList();
            // oldest3CoahcesNames.ForEach(trainerName => Console.WriteLine(trainerName));



            // Group all teams by their arenas
            var groupedTeamsByArenas = teams.GroupBy(team => team.Arena).ToList();
            //foreach (var group in groupedTeamsByArenas)
            //{
            //    Console.WriteLine($"{group.Key}");
            //    foreach (var team in group)
            //    {
            //        Console.WriteLine($"-------------{team.Name}");
            //    }
            //}


            // Find all players in one LIST
            var allPlayers = new List<Player>();
            teams.ForEach(team => allPlayers.AddRange(team.Players));
            //allPlayers.ForEach(player => Console.WriteLine(player.FullName));

            //Find player with best avgPtsPerGame
            var playerWithMostPtsPerGame = allPlayers.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                                                          .FirstOrDefault();
            //Console.WriteLine(playerWithMostPtsPerGame.FullName);


            // HOMEWORK

            // 1. Find all coaches NAMES with Age > 50
            Console.WriteLine("\n1. _____________");

            var allCoachAge50Plus = allCoaches.Where(coach => coach.Age > 50)
                                              .Select(coach => coach.FullName).ToList();
            allCoachAge50Plus.ForEach(coach => Console.WriteLine("Older than 50: " + coach));

            // 2. Order players by AGE - DESC
            Console.WriteLine("\n2. _____________");
            var orderPlayersByAgeDesc = allPlayers.OrderByDescending(player => player.Age).ToList();
            orderPlayersByAgeDesc.ForEach(player => Console.WriteLine(player.FullName + " - age: " + player.Age));

            // 3. Find player with highest RebPerGame
            Console.WriteLine("\n3. _____________");
            var playerWithHighestRebPerGame = allPlayers.OrderByDescending(player => player.PlayerStatistic["RebPerGame"])
                                        .FirstOrDefault();
            Console.WriteLine(playerWithHighestRebPerGame.FullName + " has the highest Reb Per Game.");

            // 4. Find all players with PtsPerGame > 20
            Console.WriteLine("\n4. _____________");
            var playerWith20PlusPtsPerGame = allPlayers.Where(player => player.PlayerStatistic["PtsPerGame"] > 20)
                                                        .Select(player => player.FullName)
                                                        .ToList();
            playerWith20PlusPtsPerGame.ForEach(player => Console.WriteLine(player + " has 20+ PtsPerGame."));

            // 5. Find all players NAMES older then 30 years
            Console.WriteLine("\n5. _____________");
            var playersOlderThan30 = allPlayers.Where(player => player.Age > 30)
                                                .Select(player => player.FullName).ToList();
            playersOlderThan30.ForEach(player => Console.WriteLine(player + " is older than 30."));

            // 6. Group players by age
            Console.WriteLine("\n6. _____________");
            var grouoPlayersByAge = allPlayers.GroupBy(player => player.Age);
            foreach (var item in grouoPlayersByAge)
            {
                Console.WriteLine("Players with " + item.Key + " years:");
                foreach (var player in item)
                {
                    Console.WriteLine(player.FullName);
                };
            }


            // 7. Find All players NAMES and PtsPerGame if have RebPerGame > 7.0
            Console.WriteLine("\n7. _____________");
            var playersWith7PlusRebPerGame = allPlayers.Where(player => player.PlayerStatistic["RebPerGame"] > 7.2)
                                                        //.Select(player => new { player.FullName, player.PlayerStatistic })
                                                        .ToList();
            playersWith7PlusRebPerGame.ForEach(player => Console.WriteLine("More than 7.2 RebPerGame: " + player.FullName + " " + player.PlayerStatistic["RebPerGame"]));


            // 8. Find first 3 players with highest PtsPerGame
            Console.WriteLine("\n8. _____________");
            var first3PlayersWithHighestPtsPerGame = allPlayers.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                                                                .Take(3)
                                                                .ToList();
            first3PlayersWithHighestPtsPerGame.ForEach(player => Console.WriteLine("Highest PtsPerGame: " + player.FullName + " " + player.PlayerStatistic["PtsPerGame"]));

            Console.WriteLine("\n8.1________________ Resenie so for");
            for (int i = 0; i < first3PlayersWithHighestPtsPerGame.Count; i++)
            {
                Console.WriteLine($"Number {i + 1} is {first3PlayersWithHighestPtsPerGame[i].FullName} with {first3PlayersWithHighestPtsPerGame[i].PlayerStatistic["PtsPerGame"]} points.");
            }
            Console.WriteLine("8.1________________");

            // 9. Find the team which has the player with highest PtsPerGame
            Console.WriteLine("\n9. _____________");
            var max = allPlayers.Max(player => player.PlayerStatistic["PtsPerGame"]);
            // Checking >> Console.WriteLine($"-------------{max}");

            var gropByStat = allPlayers.GroupBy(player => player.PlayerStatistic);
            string manOfTheYear = "";
            foreach (var item in gropByStat)
            {
                foreach (var player in item)
                {
                    if (player.PlayerStatistic["PtsPerGame"].Equals(max))
                    {
                        manOfTheYear = player.FullName;
                        //Console.WriteLine(player.FullName);
                    }
                }
            }
            // Checking >> Console.WriteLine(manOfTheYear);

            foreach (var team in teams)
                foreach (var item in team.Players)
                    if (item.FullName == manOfTheYear)
                        Console.WriteLine($"Highest PPG player is {item.FullName} from {team.Name}!");
            // Vo 9-tava izgleda zabegav (ali barem dava tocen rezultat) :)    

            // 10. Find first 4 players with highest RebPerGame and order them by PtsPerGame - ASC
            Console.WriteLine("\n10. _____________");
            var first4playersWithRPGOrderedByPPG = allPlayers.OrderByDescending(player => player.PlayerStatistic["RebPerGame"])
                                                .Take(4)
                                                .OrderBy(o => o.PlayerStatistic["PtsPerGame"])
                                                .ToList();
            first4playersWithRPGOrderedByPPG.ForEach(t => Console.WriteLine(t.FullName + " " + t.PlayerStatistic["RebPerGame"]));
        }
    }
}