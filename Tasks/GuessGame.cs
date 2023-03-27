class GuessGame
{
    int number { get; set; }
    public List<int> numList { get; private set; }
    public char[] numArr { get; private set; }
    public int attempts { get; private set; }
    public GuessGame(int number, int attempts)
    {
        this.attempts = attempts;
        this.number = number;
        this.numArr = number.ToString().ToCharArray();
        numList = new List<int>();
        foreach (char item in numArr)
        {
            if (!numList.Contains(item))
            {
                numList.Add(item);
            }
        }
    }
    public void Guess(int guess)
    {
        char[] guessArr = guess.ToString().ToCharArray();
        int pv = 0;
        int pm = 0;
        for (int i = 0; i < numArr.Length; i++)
        {
            if (guessArr[i] == numArr[i])
            {
                pv++;
            }
            if (numList.Contains(guessArr[i]))
            {
                pm++;
            }
        }
        System.Console.WriteLine($"Noslēpums: {number} Minējums: {guess} Paziņojums: Pareizi minēti:{pm}; Precīzā vietā:{pv}\n");
    }
}