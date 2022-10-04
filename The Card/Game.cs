Card card1 = new Card(Color.Red, Rank.One);
// card1.Color = Color.Blue;
// card1.Rank = Rank.Seven;

card1.PrintCard();

Card card2 = new Card(Color.Green, Rank.Percent);
card2.Color = Color.Green;
card2.Rank = Rank.DollarSign;

card2.PrintCard();

Card card3 = new Card(Color.Yellow, Rank.Caret);
card3.Color = Color.Yellow;
card3.Rank = Rank.Ten;

card3.PrintCard();

Card deck = new Card();
deck.PrintDeck();


Console.ReadKey(true);
