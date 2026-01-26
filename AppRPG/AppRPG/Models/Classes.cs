using System.Collections.Generic;

namespace AppRPG.Models;

public abstract class Classe
{
    public string Nom { get; }
    public int Vie { get; protected set; }
    public int Force { get; protected set; }
    public int Defense { get; protected set; }
    public int Agilite { get; protected set; }
    public int Intelligence { get; protected set; }

    protected Classe(string nom, int vie, int force, int defense, int agilite, int intelligence)
    {
        Nom = nom;
        Vie = vie;
        Force = force;
        Defense = defense;
        Agilite = agilite;
        Intelligence = intelligence;
    }

    /// <summary>
    /// Retourne une description lisible de la classe (utilisable dans l’UI)
    /// </summary>
    public virtual string Presentation()
    {
        return
            $"Classe : {Nom}\n" +
            $"Vie : {Vie}\n" +
            $"Force : {Force}\n" +
            $"Défense : {Defense}\n" +
            $"Agilité : {Agilite}\n" +
            $"Intelligence : {Intelligence}";
    }

    public Dictionary<string, int> getAttributes()
    {
        return new Dictionary<string, int>
        {
            { "PV", Vie },
            { "Strength", Force },
            { "Defence", Defense },
            { "Agility", Agilite },
            { "Intelligence", Intelligence }
        };


    }



}

public class Guerrier : Classe
{
    public Guerrier() : base(
        nom: "Guerrier",
        vie: 120,
        force: 15,
        defense: 10,
        agilite: 6,
        intelligence: 4)
    { }
}

public class Archer : Classe
{
    public Archer() : base(
        nom: "Archer",
        vie: 90,
        force: 10,
        defense: 6,
        agilite: 14,
        intelligence: 6)
    { }
}

public class Mage : Classe
{
    public Mage() : base(
        nom: "Mage",
        vie: 80,
        force: 4,
        defense: 5,
        agilite: 6,
        intelligence: 16)
    { }
}

public class Tank : Classe
{
    public Tank() : base(
        nom: "Tank",
        vie: 150,
        force: 8,
        defense: 16,
        agilite: 4,
        intelligence: 4)
    { }
}

public class Soigneur : Classe
{
    public Soigneur() : base(
        nom: "Soigneur",
        vie: 100,
        force: 5,
        defense: 7,
        agilite: 6,
        intelligence: 14)
    { }
}

public class Assassin : Classe
{
    public Assassin() : base(
        nom: "Assassin",
        vie: 85,
        force: 12,
        defense: 5,
        agilite: 18,
        intelligence: 6)
    { }
}