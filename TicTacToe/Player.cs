class Player
{
    public CellType Token { get; }
    public Player(CellType token) => Token = token;

    public Location GetChoice(Board board)
    {
        while (true)
        {
            Console.Write("What square do you want to play in? ");

            string? choiceAsString = Console.ReadLine();

            if (choiceAsString == null)
            {
                Console.WriteLine("You must enter a number");
                continue;
            }

            if (choiceAsString.Length > 1 || choiceAsString.Length == 0)
            {
                Console.WriteLine("That is not a valid choice. Try again.");
                continue;
            }

            if (choiceAsString[0] < '0' && choiceAsString[0] > '9')
            {
                Console.WriteLine("That is not a valid choice. Try again.");
                continue;
            }

            int choice = Convert.ToInt32(choiceAsString);

            Location location = ToLocation(choice);

            if (board.Get(location) == CellType.Empty)
            {
                return location;
            }

            Console.WriteLine("That square is already taken.\nTry again.");
        }

    }

    private static Location ToLocation(int choice)
    {
        return choice switch
        {
            1 => new Location(2, 2),
            2 => new Location(2, 1),
            3 => new Location(2, 0),
            4 => new Location(1, 2),
            5 => new Location(1, 1),
            6 => new Location(1, 0),
            7 => new Location(0, 2),
            8 => new Location(0, 1),
            9 => new Location(0, 0),
            _ => throw new ArgumentException("Invalid choice")
        };
    }
}