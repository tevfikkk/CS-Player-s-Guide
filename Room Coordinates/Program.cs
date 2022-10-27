Coordinate a = new Coordinate(3, 3);
Coordinate b = new Coordinate(2, 3);
Coordinate c = new Coordinate(2, 2);

Console.WriteLine(Coordinate.AreAdjacent(a, b));
Console.WriteLine(Coordinate.AreAdjacent(b, c));
Console.WriteLine(Coordinate.AreAdjacent(a, c));

Console.ReadKey(true);

struct Coordinate
{
    public int Row { get; }
    public int Column { get; }

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public static bool AreAdjacent(Coordinate c1, Coordinate c2)
    {
        int rowChange = c1.Row - c2.Row;
        int columnChange = c1.Column - c2.Column;

        if (Math.Abs(rowChange) <= 1 && columnChange == 0)
        {
            return true;
        }
        if (Math.Abs(columnChange) <= 1 && rowChange == 0)
        {
            return true;
        }
        return false;
    }

}
