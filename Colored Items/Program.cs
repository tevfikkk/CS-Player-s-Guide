ColoredItem<Sword> sword = new ColoredItem<Sword>(new Sword(), 1.2f, 3, ConsoleColor.Red);
ColoredItem<Bow> bow = new ColoredItem<Bow>(new Bow(), 4.6f, 4, ConsoleColor.Green);
ColoredItem<Axe> axe = new ColoredItem<Axe>(new Axe(), 2.1f, 2, ConsoleColor.Blue);

sword.Display();
bow.Display();
axe.Display();

Console.ReadKey(true);