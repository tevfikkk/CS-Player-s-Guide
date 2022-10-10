class FifteenPuzzleGame
{
    public void Run()
    {
        Gameboard gameboard = new Gameboard();
        PlayerInput playerInput = new PlayerInput();
        GameboardRenderer renderer = new GameboardRenderer();

        Randomize(gameboard);

        while (!gameboard.IsOver)
        {
            renderer.Render(gameboard);
            Direction toMove = playerInput.GetMove();
            gameboard.Move(toMove);
        }
        renderer.Render(gameboard);
        Console.WriteLine("You win!");
    }

    private static void Randomize(Gameboard gameboard)
    {
        Random random = new Random();
        for (int i = 0; i < 1000; i++)
        {
            Direction toMove = (Direction)random.Next(4);
            gameboard.Move(toMove);
        }
    }
}