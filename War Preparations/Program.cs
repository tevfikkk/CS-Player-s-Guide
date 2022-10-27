Sword sword = new Sword(MaterialType.Iron, GemstoneType.Diamond, 1.2f, 0.3f);

Sword ironSword = sword with
{
    Material = MaterialType.Iron,
    Gemstone = GemstoneType.Emerald,
    Length = 5.3f,
    Width = 3.4f
};

Sword steelSword = sword with
{
    Material = MaterialType.Steel,
    Gemstone = GemstoneType.Diamond,
    Length = 4.6f,
    Width = 1.3f
};

Sword woodSword = sword with
{
    Material = MaterialType.Wood,
    Gemstone = GemstoneType.Amber,
    Length = 2.3f,
    Width = 0.5f
};

List<Sword> swordList = new List<Sword>();
swordList.Add(ironSword);
swordList.Add(steelSword);
swordList.Add(woodSword);

swordList.ForEach(sword => Console.WriteLine(sword));

Console.ReadKey(true);