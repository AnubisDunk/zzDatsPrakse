class Program
{
    static void Main(string[] args)
    {
        //System.Console.WriteLine(Utils.TranslateToLat("I want to find my job")); // Uzdemums 2
        bool isWin = false;
        GuessGame game = new GuessGame(1234.ToString(), 3);

        for (int i = 0; i < game.attempts; i++)
        {
            Utils.LogColored($"\nAttempts left:{game.attempts - i}\nGuess or type E to exit:",ConsoleColor.DarkYellow);
            string input = Console.ReadLine();
            if (input == "E" || input == "e")
            {
                Utils.LogColored("Exiting",ConsoleColor.Yellow);
                break;
            }
            if (isValidInput(input, game))
            {
                game.Guess(input);
                if (input == game.number)
                {
                    Utils.LogColored("U win!", ConsoleColor.Green);

                    isWin = true;
                    break;
                }
            }
            else
            {
                Utils.LogColored($"Plaese input {game.number.Length}-digit number", ConsoleColor.Red);
            }
        }
        if (!isWin)
        {
            Utils.LogColored("Out of attempts!", ConsoleColor.Red);
        }
        Console.ReadLine();
    }
    static bool isValidInput(string input, GuessGame game)
    {
        int boundries = game.number.Length;
        if (input.Length == boundries)
        {
            return true;
        }
        else
        {
            return false;
        }


    }
}