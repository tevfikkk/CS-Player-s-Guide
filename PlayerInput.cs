class PlayerInput
{
    public Direction GetMove()
    {
        // get the player's move
        // return the direction the player wants to move
        // if the player wants to quit, return Direction.Quit
        ConsoleKey selection = Console.ReadKey(true).Key;
        return selection switch
        {
            ConsoleKey.UpArrow => Direction.Up,
            ConsoleKey.DownArrow => Direction.Down,
            ConsoleKey.LeftArrow => Direction.Left,
            ConsoleKey.RightArrow => Direction.Right,
            ConsoleKey.Q => Direction.Quit,
            _ => Direction.None
        };
    }
}


enum Direction
{
    Up,
    Down,
    Left,
    Right,
    Quit,
    None
}