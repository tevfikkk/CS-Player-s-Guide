class Card
{
    public Color Color { get; set; }
    public Rank Rank { get; set; }

    public Card(Color color, Rank rank)
    {
        Color = color;
        Rank = rank;
    }

    public Card() => (Color, Rank) = (Color.Red, Rank.One);

    public bool IsNumber() => Rank >= Rank.One && Rank <= Rank.Ten;
    public bool IsSymbol() => !IsNumber();

    public void PrintDeck()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                Card card = new Card((Color)i, (Rank)j);
                card.PrintCard();
            }
        }
    }

    public void PrintCard()
    {
        if (IsSymbol())
        {
            Console.WriteLine($"The {Color} {Rank}");
        }
        else
        {
            Console.WriteLine($"The {Color} {Rank}");
        }
    }

}


enum Color
{
    Red,
    Green,
    Blue,
    Yellow
}

enum Rank
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    DollarSign,
    Percent,
    Caret,
    Ampersand,
}