Robot robot = new Robot();

for (int i = 0; i < robot.Commands?.Length; i++)
{
    string? input = Console.ReadLine();

    RobotCommand newCommand = input switch
    {
        "on" => new OnCommand(),
        "off" => new OffCommand(),
        "north" => new NorthCommand(),
        "south" => new SouthCommand(),
        "east" => new EastCommand(),
        "west" => new WestCommand(),
        _ => throw new ArgumentException("Invalid command")
    };
    robot.Commands[i] = newCommand;
}

Console.WriteLine();

robot.Run();


Console.ReadKey(true);