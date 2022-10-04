class Color
{
    public int Red { get; }
    public int Green { get; }
    public int Blue { get; }

    public static Color BlueColor => new Color(0, 0, 255);
    public static Color RedColor => new Color(255, 0, 0);
    public static Color GreenColor => new Color(0, 255, 0);

    public Color(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    // default white
    public Color()
    {
        Red = 255;
        Green = 255;
        Blue = 255;
    }

    public Color GetColor() => new Color(Red, Green, Blue);
}