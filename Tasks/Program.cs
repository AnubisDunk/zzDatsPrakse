class Program
{
    static void Main(string[] args)
    {
        //System.Console.WriteLine(Utils.TranslateToLat("I want to find my job")); // Uzdemums 2

        GuessGame game = new GuessGame(1234, 8);

        for (int i = 0; i < game.attempts; i++)
        {

            Console.WriteLine("Guess or type E to exit:");
            string input = Console.ReadLine();
            if(input == "E"){
                Console.WriteLine("Exiting");
                break;
            }
            game.Guess(Int32.Parse(input));
        }
        Console.ReadLine();
    }
}