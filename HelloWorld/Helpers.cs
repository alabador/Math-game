using HelloWorld.Models;

namespace HelloWorld
{
    internal class Helpers
    {
        //static List<string> games = new();
        internal static List<Game> games = new List<Game>
        {
            new Game {Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5, GameAmount = 7 }
        };
        internal static int[] getDivisionNumbers()
        {
            Random random = new Random();
            int firstNumber = random.Next(0, 99);
            int secondNumber = random.Next(0, 99);

            int[] result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(0, 99);
                secondNumber = random.Next(0, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;

        }

        internal static void GetGames()
        {
            var gamesToPrint = games.Where(x => x.Type == GameType.Division);

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("---------------------");
            foreach (Game game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} out of {game.GameAmount} pts");
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }

        internal static void AddToHistory(int score, int gameAmount, GameType gameType)
        {
            games.Add(new Game {Date = DateTime.Now, Score = score, GameAmount = gameAmount, Type = gameType});
            //games.Add($"{DateTime.Now} - {gameType}: Score = {score} out of {gameAmount} ");
        }
    }
}
