Console.Write("Provide your passcode: ");
int passcode = Convert.ToInt32(Console.ReadLine());

Door door = new Door(passcode);

while (true)
{
    Console.WriteLine($"The door is {door.State}");
    Console.Write("What now? ");
    string? input = Console.ReadLine();

    bool success;

    switch (input?.ToLower())
    {
        case "open":
            success = door.Open();
            if (success) Console.WriteLine("It Worked! The door is open!");
            else Console.WriteLine("The door is locked");
            break;
        case "close":
            door.Close();
            break;
        case "lock":
            door.Lock();
            break;
        case "unlock":
            Console.WriteLine("Enter your passcode: ");
            int code = Convert.ToInt32(Console.ReadLine());
            door.Unlock(code);
            break;
        case "change code":
            Console.Write("Enter your passcode: ");
            int currentCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your new passcode: ");
            int newCode = Convert.ToInt32(Console.ReadLine());

            success = door.ChangeCode(currentCode, newCode);

            if (!success) Console.WriteLine("Wrong passcode");
            else Console.WriteLine("Passcode changed");

            break;
        default:
            Console.WriteLine("I donnu what you mean");
            break;
    }
}


// Console.ReadKey(true);