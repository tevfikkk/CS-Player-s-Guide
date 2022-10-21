class Pack
{
    public int TotalNumbersOfItems { get; } = 5;
    public float MaximumWeight { get; } = 10f;
    public float MaximumVolume { get; } = 10f;

    public float CurrentWeight { get; private set; }
    public float CurrentVolume { get; private set; }
    public int CurrentNumberOfItems { get; private set; }

    public List<InventoryItem> Items = new List<InventoryItem>();

    public bool Add(InventoryItem item)
    {
        if (item.Weight + CurrentWeight > MaximumWeight)
            return false;
        if (item.Volume + CurrentVolume > MaximumVolume)
            return false;
        if (CurrentNumberOfItems + 1 > TotalNumbersOfItems)
            return false;
        Items.Add(item);
        CurrentVolume += item.Volume;
        CurrentWeight += item.Weight;
        return true;
    }

}