using System;

namespace AppRPG.Models;

public class Item
{
    public string Name { get; }
    public string Description { get; }
    public int DurabilityMax { get; protected set; }
    public int DurabilityCurrent { get; protected set; }
    public String Rarity { get; }
    protected static readonly string[] rarities = { "Commun", "Rare", "Épique", "Légendaire" };
    protected static readonly Random random = new Random();

    public Item(
        string name,
        string description,
        int durabilityMax,
        int durabilityCurrent,
        String rarity
    )
    {
        Name = name;
        Description = description;
        DurabilityMax = durabilityMax;
        DurabilityCurrent = durabilityCurrent;
        Rarity = rarity;
    }

    public virtual string DescriptionItem()
    {
        return $"Item : {Name}\n"
            + $"Description : {Description}\n"
            + $"Durabilité : {DurabilityCurrent}/{DurabilityMax}\n"
            + $"Rareté : {Rarity}";
    }
}

public class HealPotion : Item
{
    public int HealAmount { get; }

    public HealPotion()
        : base(
            name: "HealPotion",
            description: "Restaure des points de vie.",
            durabilityMax: 1,
            durabilityCurrent: 1,
            rarity: rarities[random.Next(rarities.Length)]
        )
    {
        HealAmount = 50;
    }

    public override string DescriptionItem() =>
        base.DescriptionItem() + $"\nSoin : +{HealAmount} PV";
}

public class StrengthPotion : Item
{
    public int StrengthBonus { get; }

    public StrengthPotion()
        : base(
            name: "StrengthPotion",
            description: "Augmente la force temporairement.",
            durabilityMax: 1,
            durabilityCurrent: 1,
            rarity: rarities[random.Next(rarities.Length)]
        )
    {
        StrengthBonus = 5;
    }

    public override string DescriptionItem() =>
        base.DescriptionItem() + $"\nForce : +{StrengthBonus}";
}

public class AgilityPotion : Item
{
    public int AgilityBonus { get; }

    public AgilityPotion()
        : base(
            name: "AgilityPotion",
            description: "Augmente l'agilité temporairement.",
            durabilityMax: 1,
            durabilityCurrent: 1,
            rarity: rarities[random.Next(rarities.Length)]
        )
    {
        AgilityBonus = 5;
    }

    public override string DescriptionItem() =>
        base.DescriptionItem() + $"\nAgilité : +{AgilityBonus}";
}

public class IntelligencePotion : Item
{
    public int IntelligenceBonus { get; }

    public IntelligencePotion()
        : base(
            name: "IntelligencePotion",
            description: "Augmente l'intelligence temporairement.",
            durabilityMax: 1,
            durabilityCurrent: 1,
            rarity: rarities[random.Next(rarities.Length)]
        )
    {
        IntelligenceBonus = 5;
    }

    public override string DescriptionItem() =>
        base.DescriptionItem() + $"\nIntelligence : +{IntelligenceBonus}";
}

public class DefensePotion : Item
{
    public int DefenseBonus { get; }

    public DefensePotion()
        : base(
            name: "DefensePotion",
            description: "Augmente la défense temporairement.",
            durabilityMax: 1,
            durabilityCurrent: 1,
            rarity: rarities[random.Next(rarities.Length)]
        )
    {
        DefenseBonus = 5;
    }

    public override string DescriptionItem() =>
        base.DescriptionItem() + $"\nDéfense : +{DefenseBonus}";
}

public class GodPotion : Item
{
    public int ManaAmount { get; }

    public GodPotion()
        : base(
            name: "GodPotion",
            description: "Augmente toutes les stats temporairement.",
            durabilityMax: 1,
            durabilityCurrent: 1,
            rarity: rarities[random.Next(rarities.Length)]
        )
    {
        ManaAmount = 30;
    }

    public override string DescriptionItem() => base.DescriptionItem() + $"\nMana : +{ManaAmount}";
}
