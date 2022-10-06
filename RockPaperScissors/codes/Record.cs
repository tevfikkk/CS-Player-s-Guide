class Record
{
    public int Player1Wins { get; set; } = 0;
    public int Player2Wins { get; set; } = 0;
    public int Ties { get; set; } = 0;
}

enum PlayerChoice
{
    Rock,
    Paper,
    Scissors
}