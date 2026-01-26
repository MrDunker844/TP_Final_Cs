namespace AppRPG.Models;

public abstract class Race
{
    public string Name { get; }
    public string Description { get; }
    public string Bonus { get; }

    protected Race(string name, string description, string bonus)
    {
        Name = name;
        Description = description;
        Bonus = bonus;
    }

    public virtual string Presentation()
        => $"Race : {Name}\nDescription : {Description}\nBonus : {Bonus}";
}

public class Humain : Race
{
    public Humain() : base(
        name: "Humain",
        description: "Polyvalent et adaptable.",
        bonus: "Bonus équilibré")
    { }
}

public class Elfe : Race
{
    public Elfe() : base(
        name: "Elfe",
        description: "Agile et proche de la magie.",
        bonus: "Agilité + / Intelligence +")
    { }
}

public class Nain : Race
{
    public Nain() : base(
        name: "Nain",
        description: "Résistant et robuste.",
        bonus: "Défense + / Vie +")
    { }
}

public class Orc : Race
{
    public Orc() : base(
        name: "Orc",
        description: "Puissant et agressif.",
        bonus: "Force +")
    { }
}

public class Dragon : Race
{
    public Dragon() : base(
        name: "Dragon",
        description: "Race rare, très puissante.",
        bonus: "Vie + / Force + / Défense +")
    { }
}

public class Demon : Race
{
    public Demon() : base(
        name: "Démon",
        description: "Une race maudite possédant une grande puissance, mais instable.",
        bonus: "Force + / Intelligence + / Vie -")
    { }
}