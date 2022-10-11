class WordDictionary
{
    public string GetRandomWord()
    {
        Random random = new Random();
        return random.Next(5) switch
        {
            0 => "taco",
            1 => "burrito",
            2 => "quesadilla",
            3 => "enchilada",
            4 => "tortilla",
            _ => throw new Exception("Invalid random number")
        };
    }
}