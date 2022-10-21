Pack pack = new Pack();

pack.Add(new Arrow());
pack.Add(new Bow());
pack.Add(new Food());
pack.Add(new Rope());
pack.Add(new Sword());


pack.Add(new Water());


foreach (InventoryItem item in pack.Items)
{
    Console.WriteLine(item);
}





Console.ReadKey(true);
