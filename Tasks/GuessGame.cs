class GuessGame
{
    public string number { get; private set; }
    public List<int> numList { get; private set; }
    public int attempts { get; private set; }
    public GuessGame(int input, int attempts)
    {
        this.attempts = attempts;
        this.number = input.ToString();
        numList = new List<int>();
        for (int i = 0; i < number.Length; i++)
        {
            if (!numList.Contains(number[i]))
            {
                numList.Add(number[i]);
            }
        }
    }
    public void Guess(string guess)
    {
        int pv = 0;
        int pm = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if (guess[i] == number[i])
            {
                pv++;
            }
            if (numList.Contains(guess[i]) && !(guess[i] == number[i]))
            {
                pm++;
            }
        }
        System.Console.WriteLine($"Noslēpums: {number} Minējums: {guess} Paziņojums: Pareizi minēti:{pm}; Precīzā vietā:{pv}\n");
    }
}