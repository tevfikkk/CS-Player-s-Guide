class GameboardRenderer
{
    public void Render(Gameboard gameboard)
    {
        Console.Clear();
        for (int row = 0; row < 4; row++)
        {
            for (int column = 0; column < 4; column++)
            {
                if (gameboard.GetSquare(row, column) == 16)
                {
                    Console.Write("   ");
                }
                else
                {
                    Console.Write($"{gameboard.GetSquare(row, column):00} ");
                }
            }
            Console.WriteLine();
        }
    }
}