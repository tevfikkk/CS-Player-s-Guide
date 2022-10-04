class Point
{
    // PositionX and PositionY are not immutable
    // because the player should be able to move on the map
    public float PositionX { get; set; }
    public float PositionY { get; set; }

    // origin (0,0)
    public Point()
    {
        PositionX = 0;
        PositionY = 0;
    }

    // Point (x, y)
    public Point(float x, float y)
    {
        PositionX = x;
        PositionY = y;
    }

}