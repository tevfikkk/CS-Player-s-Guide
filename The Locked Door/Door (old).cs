class AltDoor
{
    public bool Locked { get; set; } = false; // default
    public bool Closed { get; set; } = false; // door is open by default
    public int Code { get; private set; }

    public AltDoor(int code) => Code = code;

    public void Open()
    {
        if (Locked)
        {
            Console.WriteLine("Can't open. The door is locked.");
        }
        else if (!Closed)
        {
            Console.WriteLine("The door is already open.");
        }
        else
        {
            Closed = false;
            Console.WriteLine("The door is now open.");
        }
    }

    public void Close()
    {
        if (Closed)
        {
            Console.WriteLine("The door is already closed.");
        }
        else
        {
            Closed = true;
            Console.WriteLine("The door is now closed.");
        }
    }

    public void UnLock()
    {
        while (true)
        {
            Console.WriteLine("Enter the door code: ");
            int code = Convert.ToInt32(Console.ReadLine());
            if (Locked && Code == code)
            {
                Locked = false;
                Console.WriteLine("The door is now unlocked.");
                break;
            }
            else if (!Locked)
            {
                Console.WriteLine("The door is already unlocked.");
                break;
            }
            else
            {
                Console.WriteLine("Incorrect code. Try again.");
            }
        }
    }

    public void Lock()
    {
        if (Locked)
        {
            Console.WriteLine("The door is already locked.");
        }
        else if (!Closed)
        {
            Console.WriteLine("The door is open. Close it first.");
        }
        else
        {
            Locked = true;
            Console.WriteLine("The door is now locked.");
        }
    }

    public void ChangeCode()
    {
        while (true)
        {
            Console.Write("Enter old code: ");
            int oldCode = Convert.ToInt32(Console.ReadLine());
            if (oldCode == Code)
            {
                Console.WriteLine("Enter new code: ");
                Code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Code changed! New code is {Code}");
                break;
            }
            else
            {
                Console.WriteLine("Wrong code!");
            }
        }
    }
}