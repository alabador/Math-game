using HelloWorld.Models;

namespace HelloWorld
{
    internal class GameEngine
    {
        internal void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            int score = 0;

            Console.WriteLine("How many games would you like to play?");
            int gameAmount = int.Parse(Console.ReadLine());

            for (int i = 0; i < gameAmount; i++)
            {
                int[] divisionNumbers = Helpers.getDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"What is {firstNumber} / {secondNumber}?");
                int result = int.Parse(Console.ReadLine());

                if (result == firstNumber / secondNumber)
                {
                    Console.Clear();
                    Console.WriteLine("You got it correct!");
                    score++;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong...");
                }
            }

            Helpers.AddToHistory(score, gameAmount, GameType.Division);


            Console.Clear();
            Console.WriteLine($"Game over. Your score is {score} out of {gameAmount}!");


        }
        internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            int score = 0;

            Random random = new Random();

            Console.WriteLine("How many games would you like to play?");
            int gameAmount = int.Parse(Console.ReadLine());

            for (int i = 0; i < gameAmount; i++)
            {
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);

                Console.WriteLine($"What is {firstNumber} * {secondNumber}?");
                int result = int.Parse(Console.ReadLine());

                if (result == firstNumber * secondNumber)
                {
                    Console.Clear();
                    Console.WriteLine("You got it correct!");
                    score++;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong...");
                }
            }

            Helpers.AddToHistory(score, gameAmount, GameType.Multiplication);


            Console.Clear();
            Console.WriteLine($"Game over. Your score is {score} out of {gameAmount}!");
        }
        internal void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            int score = 0;

            Random random = new Random();

            Console.WriteLine("How many games would you like to play?");
            int gameAmount = int.Parse(Console.ReadLine());

            for (int i = 0; i < gameAmount; i++)
            {
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);

                Console.WriteLine($"What is {firstNumber} - {secondNumber}?");
                int result = int.Parse(Console.ReadLine());

                if (result == firstNumber - secondNumber)
                {
                    Console.Clear();
                    Console.WriteLine("You got it correct!");
                    score++;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong...");
                }
            }

            Helpers.AddToHistory(score, gameAmount, GameType.Subtraction);


            Console.Clear();
            Console.WriteLine($"Game over. Your score is {score} out of {gameAmount}!");
        }
        internal void AdditionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            int score = 0;

            Random random = new Random();

            Console.WriteLine("How many games would you like to play?");
            int gameAmount = int.Parse(Console.ReadLine());

            for (int i = 0; i < gameAmount; i++)
            {
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);

                Console.WriteLine($"What is {firstNumber} + {secondNumber}?");
                int result = int.Parse(Console.ReadLine());

                if (result == firstNumber + secondNumber)
                {
                    Console.Clear();
                    Console.WriteLine("You got it correct!");
                    score++;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong...");
                }
            }

            Helpers.AddToHistory(score, gameAmount, GameType.Addition);

            Console.Clear();
            Console.WriteLine($"Game over. Your score is {score} out of {gameAmount}!");
        }
    }
}
