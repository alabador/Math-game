namespace HelloWorld
{
    internal class Helpers
    {
        static List<string> games = new();
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
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("---------------------");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }

        internal static void AddToHistory(int score, int gameAmount, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: Score = {score} out of {gameAmount} ");
        }
    }
}
