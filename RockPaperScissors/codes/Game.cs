class Game
{
    public Player Player1 { get; }
    public Player Player2 { get; }
    public Record Record { get; private set; }

    public Game()
    {
        Player1 = new Player();
        Player2 = new Player();
        Record = new Record();
    }

    // The Run method is the main game loop
    public void Run()
    {
        while (true)
        {
            Console.Write($"Player1's turn: ");
            PlayerChoice choice1 = Player1.GetChoice();
            Console.Write($"Player2's turn: ");
            PlayerChoice choice2 = Player2.GetChoice();
            int winner = DetermineWinner(choice1, choice2);
            UpdateRecord(winner);
            string x = DisplayOutcome(winner);
            Console.WriteLine($"\n{x}\n");
        }
    }

    private void UpdateRecord(int winner)
    {
        if (winner == 1)
        {
            Record.Player1Wins++;
        }
        else if (winner == 2)
        {
            Record.Player2Wins++;
        }
        else
        {
            Record.Ties++;
        }
    }

    private int DetermineWinner(PlayerChoice choice1, PlayerChoice choice2)
    {

        if (choice1 == choice2)
        {
            return 0;
        }

        if (choice1 == PlayerChoice.Rock)
        {
            if (choice2 == PlayerChoice.Paper)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        if (choice1 == PlayerChoice.Paper)
        {
            if (choice2 == PlayerChoice.Scissors)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        if (choice1 == PlayerChoice.Scissors)
        {
            if (choice2 == PlayerChoice.Rock)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        return 0;
    }

    private string DisplayOutcome(int winner)
    {
        if (winner == 0)
        {
            return $"Tie!\nPlayer1: {Record.Player1Wins}\nPlayer2: {Record.Player2Wins}\nTies: {Record.Ties}";
        }
        else if (winner == 1)
        {
            return $"Player 1 wins!\nPlayer1: {Record.Player1Wins}\nPlayer2: {Record.Player2Wins}\nTies: {Record.Ties}";
        }
        else
        {
            return $"Player 2 wins!\nPlayer1: {Record.Player1Wins}\nPlayer2: {Record.Player2Wins}\nTies: {Record.Ties}";
        }
    }
}

