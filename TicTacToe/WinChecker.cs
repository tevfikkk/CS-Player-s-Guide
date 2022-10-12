class WinChecker
{
    public bool HasXWon(Board board) => HasWon(board, CellType.X);
    public bool HasOWon(Board board) => HasWon(board, CellType.O);

    private bool HasWon(Board board, CellType type)
    {
        bool[,] match = new bool[3, 3];
        for (int row = 0; row < 3; row++)
        {
            for (int column = 0; column < 3; column++)
            {
                match[row, column] = board.Get(row, column) == type;
            }
        }

        if (match[0, 0] && match[0, 1] && match[0, 2])
        {
            return true;
        }
        if (match[1, 0] && match[1, 1] && match[1, 2])
        {
            return true;
        }
        if (match[2, 0] && match[2, 1] && match[2, 2])
        {
            return true;
        }

        if (match[0, 0] && match[1, 0] && match[2, 0])
        {
            return true;
        }
        if (match[0, 1] && match[1, 1] && match[2, 1])
        {
            return true;
        }
        if (match[0, 2] && match[1, 2] && match[2, 2])
        {
            return true;
        }


        if (match[0, 0] && match[1, 1] && match[2, 2])
        {
            return true;
        }
        if (match[0, 2] && match[1, 1] && match[2, 0])
        {
            return true;
        }

        return false;
    }

    public bool IsBoardFull(Board board)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int column = 0; column < 3; column++)
            {
                if (board.Get(new Location(row, column)) == CellType.Empty)
                {
                    return false;
                }
            }
        }
        return true;
    }
}