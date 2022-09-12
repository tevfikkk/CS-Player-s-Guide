Arrow arr1 = new Arrow();
Arrow arr2 = new Arrow(ArrowheadType.Obsidian, FletchingType.TurkeyFeathers, 13);

ArrowheadType arrowheadType = GetArrowheadType();
FletchingType fletchingType = GetFletchingType();
float length = GetLength();

Arrow arrow = new Arrow(arrowheadType, fletchingType, length);

Console.WriteLine($"Your arrowhead is {arrow.arrowhead}\nFletching is {arrow.fletching}\n" +
    $"and {arrow.lengthInCent}");

Console.WriteLine("");

Console.WriteLine($"This arrow costs {arrow.GetCost()} gold");

Console.ReadKey(true);

ArrowheadType GetArrowheadType()
{
    while (true)
    {
        Console.WriteLine("Pick a arrowhead type:\n1-Steel\n2-Wood\n3-Obsidian");
        string? input = Console.ReadLine();

        bool invalidInput = input != "1" && input != "2" && input != "3";

        if (invalidInput)
        {
            Console.WriteLine("There are no arrows corresponding to your input!");
        }
        else
        {
            ArrowheadType arrowheadType = Enum.Parse<ArrowheadType>(input);

            Console.WriteLine($"Arrow Type is: {arrowheadType}, {arrowheadType.GetType()}");

            return arrowheadType;
        }
    }
}

FletchingType GetFletchingType()
{
    while (true)
    {
        Console.WriteLine("Pick a fletching type:\n1-Plastic\n2-Turkey Feathers\n3-Goose Feathers");
        string? input = Console.ReadLine();

        bool invalidInput = input != "1" && input != "2" && input != "3";

        if (invalidInput)
        {
            Console.WriteLine("There are no arrows corresponding to your input!");
        }
        else
        {
            FletchingType fletchingType = Enum.Parse<FletchingType>(input);

            Console.WriteLine($"Fletching Type is: {fletchingType}, {fletchingType.GetType()}");

            return fletchingType;
        }
    }
}

float GetLength()
{
    while (true)
    {
        Console.WriteLine("Pick a length of your arrow in centemeter between 60 : 100");
        float option = Convert.ToSingle(Console.ReadLine());

        if (option < 60 || option > 100)
        {
            Console.WriteLine($"You picked {option} which cannot be accepted\nPlease choose between 60 : 100");
        }
        else
        {
            return option;
        }
    }
}

class Arrow
{
    public ArrowheadType arrowhead;
    public FletchingType fletching;
    public float lengthInCent; // Length in Centimeters!

    public Arrow(ArrowheadType arrowhead, FletchingType fletching, float length)
    {
        this.arrowhead = arrowhead;
        this.fletching = fletching;
        lengthInCent = length;
    }

    public Arrow() : this(ArrowheadType.Steel, FletchingType.Plastic, 25) { }

    public float GetCost()
    {
        float cost = 0;
        cost += 0.05f * lengthInCent;

        cost += arrowhead switch
        {
            ArrowheadType.Steel => 10,
            ArrowheadType.Wood => 3,
            ArrowheadType.Obsidian => 5,
            // _ => 0
        };

        cost += fletching switch
        {
            FletchingType.Plastic => 10,
            FletchingType.TurkeyFeathers => 5,
            FletchingType.GooseFeathers => 3,
            // _ => 0
        };

        return cost;
    }

}

enum ArrowheadType { Steel = 1, Wood = 2, Obsidian = 3 }

enum FletchingType { Plastic = 1, TurkeyFeathers = 2, GooseFeathers = 3 }