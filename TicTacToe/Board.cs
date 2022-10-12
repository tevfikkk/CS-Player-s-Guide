class Board
{
    private readonly CellType[,] _cells = new CellType[3, 3];

    public void Set(Location location, CellType newType)
    {
        if (newType == CellType.Empty)
        {
            Console.Write("   ");
            return;
        }

        if (_cells[location.Row, location.Column] != CellType.Empty)
        {
            return;
        }

        _cells[location.Row, location.Column] = newType;
    }

    public CellType Get(Location location) => _cells[location.Row, location.Column];

    public CellType Get(int row, int column) => _cells[row, column];

    public Board()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int column = 0; column < 3; column++)
            {
                _cells[row, column] = CellType.Empty;
            }
        }
    }
}

enum CellType { Empty, X, O }