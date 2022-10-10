class Gameboard
{
    private readonly int[,] squares; // numbers 1 through 15, and 16 is the empty slot

    public Gameboard()
    {
        // Initialize the gameboard
        squares = new int[4, 4];
        for (int row = 0; row < 4; row++)
        {
            for (int column = 0; column < 4; column++)
            {
                squares[row, column] = row * 4 + column + 1;
            }
        }
    }

    public int GetSquare(int row, int column) => squares[row, column];

    public void Move(Direction direction)
    {
        (int row, int column) = GetOpenLocation();

        if (direction == Direction.Right && column > 0)
        {
            Swap(row, column, row, column - 1);
        }
        else if (direction == Direction.Left && column < 3)
        {
            Swap(row, column, row, column + 1);
        }
        else if (direction == Direction.Up && row < 3)
        {
            Swap(row, column, row + 1, column);
        }
        else if (direction == Direction.Down && row > 0)
        {
            Swap(row, column, row - 1, column);
        }
    }

    public bool IsOver
    {
        get
        {
            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    if (squares[row, column] != row * 4 + column + 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }

    private void Swap(int row1, int column1, int row2, int column2)
    {
        int temp = squares[row1, column1];
        squares[row1, column1] = squares[row2, column2];
        squares[row2, column2] = temp;
    }

    private (int, int) GetOpenLocation()
    {
        for (int row = 0; row < 4; row++)
        {
            for (int column = 0; column < 4; column++)
            {
                if (squares[row, column] == 16)
                {
                    return (row, column);
                }
            }
        }
        return (0, 0);
    }
}