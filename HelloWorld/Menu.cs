
namespace HelloWorld
{
    internal class Menu
    {
        GameEngine engine = new();

        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine($"Hello {name}! Today is {date}.\n");

            bool isGameOn = true;

            do
            {
                Console.WriteLine(@$"What kind of game would you like to play today?
V- View Previous Games
A - Addition
S- Subtraction
M - Multiplication
D - Division
Q- Quit
        ");

                string gameSelected = Console.ReadLine();
                if (gameSelected.ToUpper() == "A")
                {
                    engine.AdditionGame("It's addition time!");
                }
                else if (gameSelected.Trim().ToUpper() == "S")
                {
                    engine.SubtractionGame("It's subtraction time!");
                }
                else if (gameSelected.Trim().ToUpper() == "M")
                {
                    engine.MultiplicationGame("It's multiplication time!");
                }
                else if (gameSelected.Trim().ToUpper() == "D")
                {
                    engine.DivisionGame("It's division time!");
                }
                else if (gameSelected.Trim().ToUpper() == "Q")
                {
                    Console.WriteLine("Quitting game.");
                    Environment.Exit(1);
                }
                else if (gameSelected.Trim().ToUpper() == "V")
                {
                    Helpers.GetGames();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            } while (isGameOn);
        }
    }
}
