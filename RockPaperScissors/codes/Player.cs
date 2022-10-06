class Player
{
    public PlayerChoice GetChoice()
    {
        string? input = Console.ReadLine();
        PlayerChoice choice = Enum.Parse<PlayerChoice>(input ?? PlayerChoice.Rock.ToString());
        return choice;
    }
}