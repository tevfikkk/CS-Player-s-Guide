class ColoredItem<T1>
{
    public float Length { get; set; }
    public int Age { get; set; }
    public T1? Item { get; set; }
    public ConsoleColor Color { get; set; }

    public ColoredItem(T1? item, float length, int age, ConsoleColor color)
    {
        Item = item;
        Length = length;
        Age = age;
        Color = (ConsoleColor)Enum.Parse<ConsoleColor>(color.ToString());
    }

    public void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"Item is {Item} with length {Length} and age {Age}");
    }

}