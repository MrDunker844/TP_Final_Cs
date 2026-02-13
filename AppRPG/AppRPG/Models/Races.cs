namespace AppRPG.Models;

public abstract class Race
{
    public string Name { get; }
    public string Description { get; }
    public string Bonus { get; }
    public int Force { get; }
    public int Agility { get; }
    public int PV { get; }
    public int Intelligence { get; }
    public int Defence { get; }
    public string Compatibility { get; }
    public string Incompatibility { get; }
    
    

    protected Race(string name, string description, string stat, int force, int agility, int pv, int intelligence, int defence, string compatibility, string incompatibility)
    {
        Name = name;
        Description = description;
        Bonus = stat;
        Force = force;
        Agility = agility;
        PV = pv;
        Intelligence = intelligence;
        Defence = defence;
        Compatibility = compatibility;
        Incompatibility = incompatibility;
    }

    public virtual string Presentation()
        => $"Race : {Name}\nDescription : {Description}\nBonus : {Bonus}";
    public virtual int GetForce() => Force;
    public virtual int GetAgility() => Agility;
    public virtual int GetPV() => PV;
    public virtual int GetIntelligence() => Intelligence;
    public virtual int GetDefence() => Defence;
    
}

public class Humain : Race
{
    public Humain() : base(
        name: "Humain",
        description: "Polyvalent et adaptable.",
        stat: "Bonus équilibré",
        force: 10,
        agility: 10,
        pv: 10,
        intelligence: 10,
        defence: 10,
        compatibility: "",
        incompatibility: "")
    {
    }
}

public class Elfe : Race
{
    public Elfe() : base(
        name: "Elfe",
        description: "Agile et proche de la magie.",
        stat: "Agilité + / Intelligence +",
        force: 8,
        agility: 14,
        pv: 8,
        intelligence: 14,
        defence: 6,
        compatibility: "Voleur",
        incompatibility: "Tank")
    { }
}

public class Nain : Race
{
    public Nain() : base(
        name: "Nain",
        description: "Résistant et robuste.",
        stat: "Défense + / Vie +",
        force: 12,
        agility: 6,
        pv: 14,
        intelligence: 8,
        defence: 16,
        compatibility: "Tank",
        incompatibility: "Voleur")
    { }
}

public class Orc : Race
{
    public Orc() : base(
        name: "Orc",
        description: "Puissant et agressif.",
        stat: "Force +",
        force: 14,
        agility: 8,
        pv: 12,
        intelligence: 8,
        defence: 10,
        compatibility: "Guerrier",
        incompatibility: "Mage")
    { }
}

public class Dragon : Race
{
    public Dragon() : base(
        name: "Dragon",
        description: "Race rare, très puissante.",
        stat: "Vie + / Force + / Défense +",
        force: 20,
        agility: 12,
        pv: 20,
        intelligence: 12,
        defence: 18,
        compatibility: "",
        incompatibility: "")
    { }
}

public class Demon : Race
{
    public Demon() : base(
        name: "Demon",
        description: "Une race maudite possédant une grande puissance, mais instable.",
        stat: "Force + / Intelligence + / Vie -",
        force: 18,
        agility: 10,
        pv: 9,
        intelligence: 12,
        defence: 10,
        compatibility: "Assassin",
        incompatibility: "Altruiste")
    { }
}