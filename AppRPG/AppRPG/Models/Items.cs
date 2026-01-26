namespace AppRPG.Models;

public class Item
{
    public string Name { get; }
    public string Description { get; }
    public int DurabilityMax { get; protected set; }
    public int DurabilityCurrent { get; protected set; }
    public int Rarity { get; }

    public Item(string name, string description, int durabilityMax, int durabilityCurrent, int rarity)
    {
        Name = name;
        Description = description;
        DurabilityMax = durabilityMax;
        DurabilityCurrent = durabilityCurrent;
        Rarity = rarity;
    }

    public virtual string DescriptionItem()
    {
        return
            $"Item : {Name}\n" +
            $"Description : {Description}\n" +
            $"Durabilité : {DurabilityCurrent}/{DurabilityMax}\n" +
            $"Rareté : {Rarity}";
    }
}

// -------------------- POTIONS --------------------

public class HealPotion : Item
{
    public int HealAmount { get; }

    public HealPotion() : base(
        name: "Potion de soin",
        description: "Restaure des points de vie.",
        durabilityMax: 1,
        durabilityCurrent: 1,
        rarity: 2)
    {
        HealAmount = 50;
    }

    public override string DescriptionItem()
        => base.DescriptionItem() + $"\nSoin : +{HealAmount} PV";
}

public class StrengthPotion : Item
{
    public int StrengthBonus { get; }

    public StrengthPotion() : base(
        name: "Potion de force",
        description: "Augmente la force temporairement.",
        durabilityMax: 1,
        durabilityCurrent: 1,
        rarity: 3)
    {
        StrengthBonus = 5;
    }

    public override string DescriptionItem()
        => base.DescriptionItem() + $"\nForce : +{StrengthBonus}";
}

// -------------------- ARMES --------------------

public class Weapon
{
    public string Name { get; }
    public string Description { get; }
    public int Damage { get; }
    public int DurabilityMax { get; protected set; }
    public int DurabilityCurrent { get; protected set; }
    public int Rarity { get; }

    public Weapon(string name, string description, int damage, int durabilityMax, int durabilityCurrent, int rarity)
    {
        Name = name;
        Description = description;
        Damage = damage;
        DurabilityMax = durabilityMax;
        DurabilityCurrent = durabilityCurrent;
        Rarity = rarity;
    }

    public virtual string DescriptionWeapon()
    {
        return
            $"Arme : {Name}\n" +
            $"Description : {Description}\n" +
            $"Dégâts : {Damage}\n" +
            $"Durabilité : {DurabilityCurrent}/{DurabilityMax}\n" +
            $"Rareté : {Rarity}";
    }
}

public class Sword : Weapon
{
    public Sword() : base(
        name: "Épée",
        description: "Une épée tranchante en acier.",
        damage: 50,
        durabilityMax: 100,
        durabilityCurrent: 100,
        rarity: 3)
    { }
}

public class Bow : Weapon
{
    public Bow() : base(
        name: "Arc",
        description: "Un arc précis pour les attaques à distance.",
        damage: 40,
        durabilityMax: 90,
        durabilityCurrent: 90,
        rarity: 2)
    { }
}

public class Staff : Weapon
{
    public Staff() : base(
        name: "Bâton",
        description: "Un bâton magique amplifiant les sorts.",
        damage: 45,
        durabilityMax: 80,
        durabilityCurrent: 80,
        rarity: 3)
    { }
}

public class Dagger : Weapon
{
    public Dagger() : base(
        name: "Dague",
        description: "Une lame courte, rapide et discrète.",
        damage: 35,
        durabilityMax: 70,
        durabilityCurrent: 70,
        rarity: 2)
    { }
}

public class Axe : Weapon
{
    public Axe() : base(
        name: "Hache",
        description: "Une arme lourde infligeant de gros dégâts.",
        damage: 60,
        durabilityMax: 90,
        durabilityCurrent: 90,
        rarity: 3)
    { }
}

public class Mace : Weapon
{
    public Mace() : base(
        name: "Masse",
        description: "Une masse contondante en métal.",
        damage: 65,
        durabilityMax: 85,
        durabilityCurrent: 85,
        rarity: 3)
    { }
}