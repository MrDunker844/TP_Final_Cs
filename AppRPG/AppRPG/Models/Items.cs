namespace DefaultNamespace;

public class Items
{
    public string Name;
    public string Description;
    public int DurabilityMax;
    public int DurabilityCurrent;
    public int Rarity;

    public Items(string _name, string _description, int _durabilityMax, int _durabilityCurrent, int _rarity)
    {
        Name = _name;
        Description = _description;
        DurabilityMax = _durabilityMax;
        DurabilityCurrent = _durabilityCurrent;
        Rarity = _rarity;
    }
}