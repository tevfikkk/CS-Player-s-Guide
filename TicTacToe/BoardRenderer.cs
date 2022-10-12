class BoardRenderer
{
    public void Render(Board board)
    {
        char[,] characters = new char[3, 3];
        for (int row = 0; row < characters.GetLength(0); row++)
        {
            for (int column = 0; column < characters.GetLength(1); column++)
            {
                characters[row, column] = ToCharacter(board.Get(new Location(row, column)));
            }
        }

        Console.WriteLine($" {characters[0, 0]} | {characters[0, 1]} | {characters[0, 2]} ");
        Console.WriteLine($"---+---+---");
        Console.WriteLine($" {characters[1, 0]} | {characters[1, 1]} | {characters[1, 2]} ");
        Console.WriteLine($"---+---+---");
        Console.WriteLine($" {characters[2, 0]} | {characters[2, 1]} | {characters[2, 2]} ");
    }

    private char ToCharacter(CellType cellType)
    {
        return cellType switch
        {
            CellType.Empty => ' ',
            CellType.X => 'X',
            CellType.O => 'O',
            _ => throw new ArgumentException("Invalid cell type")
        };
    }
}
