class HangmanGame
{
    public string WordToGuess { get; }
    public int RemainingGuesses { get; private set; } = 5;
    public bool[] HasBeenRevealed { get; private set; }
    public List<char> WrongGuesses { get; private set; }

    public HangmanGame(string wordToGuess)
    {
        WordToGuess = wordToGuess;
        HasBeenRevealed = new bool[wordToGuess.Length];
        WrongGuesses = new List<char>();
    }

    // Runs the game
    public void Run()
    {
        GameRenderer renderer = new GameRenderer();
        PlayerInput input = new PlayerInput();
        while (!HasWon() && !HasLost())
        {
            renderer.Render(this);
            char guess = input.GetGuess();

            bool revealedSomething = false;
            for (int i = 0; i < WordToGuess.Length; i++)
            {
                if (WordToGuess[i] == guess)
                {
                    HasBeenRevealed[i] = true;
                    revealedSomething = true;
                }
            }
            if (!revealedSomething)
            {
                RemainingGuesses--;
                WrongGuesses.Add(guess);

                // 
                // char[] updatedWrongGuesses = new char[WrongGuesses.Length + 1];
                // Array.Copy(WrongGuesses, updatedWrongGuesses, WrongGuesses.Length);
                // updatedWrongGuesses[^1] = guess;
                // WrongGuesses = updatedWrongGuesses;
            }
        }
    }

    public bool HasWon() => HasBeenRevealed.All(x => !x ? false : true);
    public bool HasLost() => RemainingGuesses == 0;
}