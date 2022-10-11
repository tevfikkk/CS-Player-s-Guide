class PlayerInput
{
    public char GetGuess() => Convert.ToChar(Console.ReadLine().ToUpper() ?? throw new Exception("Invalid input"));
}