class GameRenderer
{
    public void Render(HangmanGame hangmanGame)
    {
        Console.Write("Word: ");
        for (int i = 0; i < hangmanGame.WordToGuess.Length; i++)
        {
            if (hangmanGame.HasBeenRevealed[i])
            {
                Console.Write(hangmanGame.WordToGuess[i]);
            }
            else
            {
                Console.Write("_");
            }
        }
        Console.Write($"| Remaining: {hangmanGame.RemainingGuesses} | Incorrect: ");
        foreach (char letter in hangmanGame.WrongGuesses)
        {
            Console.Write(letter);
        }
        Console.Write(" | Guesses: ");
    }
}