namespace HelloWorld.Models
{
    internal class Game
    {
        //private int _score;
        //public int Score {
        //    get { return _score; } 
        //    set { _score = value; } 
        //}
        //the methods below are shorthand for the above.
        internal DateTime Date { get; set; }
        internal int Score { get; set; }
        internal int GameAmount { get; set; }
        internal GameType Type { get; set; }
    }

    internal enum GameType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
    }
}
