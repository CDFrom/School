using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Game
    {
        public readonly string Name;
        public readonly string Platform;
        public readonly int ReleaseYear;
        public readonly string Genre;
        public readonly string Publisher;
        public readonly double NASales;
        public readonly double EUSales;
        public readonly double JPSales;
        public readonly double OtherSales;
        //public readonly double GlobalSales;
        public readonly double CriticScore;
        public readonly int CriticCount;
        public readonly double UserScore;
        public readonly int UserCount;
        public readonly string Rating;

        private string NextValue(string csv, ref int index)
        {
            string result = "";
            if (index < csv.Length)
            {
                if (csv[index] == ',')
                {
                    index++;
                }
                else if (csv[index] == '"')
                {
                    int endIndex = csv.IndexOf('"', index + 1);
                    result = csv.Substring(index + 1, endIndex - (index + 1));
                    index = endIndex + 2;
                }
                else
                {
                    int endIndex = csv.IndexOf(',', index);
                    if (endIndex == -1)
                        result = csv.Substring(index);
                    else
                        result = csv.Substring(index, endIndex - index);
                    index = endIndex + 1;
                }
            }
            return result;
        }

        public Game(string csv)
        {
            int index = 0;
            Name = NextValue(csv, ref index);
            Platform = NextValue(csv, ref index);
            int.TryParse(NextValue(csv, ref index), out ReleaseYear);
            Genre = NextValue(csv, ref index);
            Publisher = NextValue(csv, ref index);
            double.TryParse(NextValue(csv, ref index), out NASales);
            double.TryParse(NextValue(csv, ref index), out EUSales);
            double.TryParse(NextValue(csv, ref index), out JPSales);
            double.TryParse(NextValue(csv, ref index), out OtherSales);
            NextValue(csv, ref index); //public readonly double GlobalSales;
            double.TryParse(NextValue(csv, ref index), out CriticScore);
            int.TryParse(NextValue(csv, ref index), out CriticCount);
            double.TryParse(NextValue(csv, ref index), out UserScore);
            int.TryParse(NextValue(csv, ref index), out UserCount);
            Rating = NextValue(csv, ref index);
        }
    }

    class Program
    {
        static List<Game> Games = new List<Game>();

        static void BuildDB()
        {
            string input;
            while ((input = Console.ReadLine()) != "")
            {
                var game = new Game(input);
                Games.Add(game);
            }
        }

        static void BuildDBFromFile()
        {
            using (var reader = File.OpenText("Video Game Sales 2017.csv"))
            {
                string input = reader.ReadLine(); // Skip label row
                while ((input = reader.ReadLine()) != null)
                {
                    var game = new Game(input);
                    Games.Add(game);
                }
            }
        }

        static void Main(string[] args)
        {
            BuildDBFromFile();

            // Part 1
            {
                // Write your code here
                // Showing an example of a basic query
                Console.WriteLine("Show all games that have a user score of 9.5 or higher:"); // The query being asked

                var results = Games.Where(game => game.UserScore >= 9.5); // The query

                // Display the results
                foreach (var game in results)
                {
                    Console.WriteLine("{0,50}{1,5}",game.Name, game.UserScore);
                }
                Console.WriteLine();
            }

            // Part 2
            {
                // Write your code here
                // Showing an example of a fluent query
                Console.WriteLine("List the top 10 games for PS4 released in 2014 based on sales in Japan:"); //The query being asked

                // The query
                var results = Games
                    .Where(game => game.Platform == "PS4" && game.ReleaseYear == 2014)
                    .OrderByDescending(game => game.JPSales)
                    .Take(10);

                //Display the results
                foreach (var game in results)
                {
                    Console.WriteLine("{0,35}{1,10}{2,10}{3,15}", game.Name, game.Platform, game.ReleaseYear, game.JPSales);
                }
                Console.WriteLine();
            }

            // Part 3
            {
                // Write your code here
                // Showing an example of projection
                Console.WriteLine("List the top role-playing game for each platform based on the number of sales in North America:"); // The query being asked

                // The query
                var results = Games
                    .Where(game => game.Genre == "Role-Playing")
                    .OrderByDescending(game => game.NASales)
                    .GroupBy(game => game.Platform)
                    .Select(group => new
                    {
                        Platform = group.Key,
                        TopGame = group.First()
                    });

                // Display the results
                foreach (var group in results)
                {
                    Console.WriteLine("{0,10}{1,50}{2,15}{3,10}", group.Platform, group.TopGame.Name, group.TopGame.Genre, group.TopGame.NASales);
                }
                Console.WriteLine();
            }

            // Part 4
            {
                // Write your code here
                // Showing an example of query syntax
                Console.WriteLine("List the game with the highest total sales published by 'Nintendo' for each release year between 2000 and 2010:"); // The query being asked

                // The query
                var results =
                    (from game in Games
                     where game.Publisher == "Nintendo" && game.ReleaseYear >= 2000 && game.ReleaseYear <= 2010
                     orderby game.NASales + game.JPSales + game.EUSales + game.OtherSales descending
                     group game by game.ReleaseYear into gameGroup
                     select new
                     {
                         ReleaseYear = gameGroup.Key,
                         TopGame = gameGroup.First()
                     })
                     .OrderBy(gameGroup => gameGroup.ReleaseYear);

                // Display the results
                foreach (var game in results)
                {
                    Console.WriteLine("{0,10}{1,40}{2,10}{3,10}", game.ReleaseYear, game.TopGame.Name, game.TopGame.Publisher, game.TopGame.NASales + game.TopGame.JPSales + game.TopGame.EUSales + game.TopGame.OtherSales);
                }
                Console.WriteLine();
            }

            // Part 5
            {
                // Write your code here
                Console.WriteLine("List the top selling genre for each year between 1996 and 2016: "); // The query being asked

                // The query
                var results = Games
                    .Where(game => game.ReleaseYear >= 1996 && game.ReleaseYear <= 2016)
                    .GroupBy(game => new
                    {
                        game.ReleaseYear,
                        game.Genre
                    })
                    .Select(group => new
                    {
                        ReleaseYear = group.Key.ReleaseYear,
                        Genre = group.Key.Genre,
                        TotalSales = Math.Round(group.Sum(game => game.NASales + game.EUSales + game.JPSales + game.OtherSales), 2)
                    })
                    .OrderByDescending(group => group.TotalSales)
                    .GroupBy(group => group.ReleaseYear)
                    .Select(group => new
                    {
                        ReleaseYear = group.Key,
                        TopGenre = group.First().Genre,
                        TotalSales = group.First().TotalSales
                    })
                    .OrderBy(group => group.ReleaseYear);

                // Display the results
                foreach (var group in results)
                {
                    Console.WriteLine("{0,10}{1,20}{2,10}", group.ReleaseYear, group.TopGenre, group.TotalSales);
                }
                Console.WriteLine();
            }

            // Part 6
            {
                // Write your code here
                Console.WriteLine("List the platforms with the highest number of releases for each year between 1990 and 2017:"); // The query being asked

                // The query
                var results =
                    (from game in Games
                     where game.ReleaseYear >= 1990 && game.ReleaseYear <= 2017
                     group game by new { game.ReleaseYear, game.Platform })
                    .Select(group => new
                    {
                        Year = group.Key.ReleaseYear,
                        Platform = group.Key.Platform,
                        NumberOfReleasedGames = group.Count()
                    })
                    .OrderByDescending(group => group.NumberOfReleasedGames)
                    .GroupBy(group => group.Year)
                    .Select(group => new
                    {
                        Year = group.Key,
                        Platform = group.First().Platform,
                        NumberOfReleasedGames = group.First().NumberOfReleasedGames
                    })
                    .OrderBy(group => group.Year);

                // Display the results
                foreach (var group in results)
                {
                    Console.WriteLine("{0,10}{1,10}{2,10}", group.Year, group.Platform, group.NumberOfReleasedGames);
                }
                Console.WriteLine();
            }

        }
    }
}
