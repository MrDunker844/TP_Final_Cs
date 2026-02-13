using System.Collections.Generic;

namespace AppRPG.Models;

public abstract class Classe
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
    public Dictionary<string, int> CombinaisonBonus { get; }
    public int UpgradePoints { get; }

    protected Classe(string name, string description, string bonus, int force, int agility,
    int pv, int intelligence, int defence, string compatibility,string incompatibility,
    Dictionary<string, int> combinaisonBonus = null,int upgradePoints = 0)
    {
        Name = name;
        Description = description;
        Bonus = bonus;
        Force = force;
        Agility = agility;
        PV = pv;
        Intelligence = intelligence;
        Defence = defence;
        Compatibility = compatibility;
        Incompatibility = incompatibility;
        CombinaisonBonus = combinaisonBonus ?? new Dictionary<string, int>();// ?? veut dire si droite null alors gauche 
        UpgradePoints = upgradePoints;
    }

    
    public virtual string Presentation()
    {
        return
            $"Classe : {Name}\n" +
            $"Vie : {PV}\n" +
            $"Force : {Force}\n" +
            $"Défense : {Defence}\n" +
            $"Agilité : {Agility}\n" +
            $"Intelligence : {Intelligence}";
    }

    public Dictionary<string, int> getAttributes()
    {
        return new Dictionary<string, int>
        {
            { "PV", PV },
            { "Strength", Force },
            { "Defence", Defence },
            { "Agility", Agility },
            { "Intelligence", Intelligence }
        };
    }
    public virtual int GetForce() => Force;
    public virtual int GetAgility() => Agility;
    public virtual int GetPV() => PV;
    public virtual int GetIntelligence() => Intelligence;
    public virtual int GetDefence() => Defence;



}

public class Guerrier : Classe
{
    public Guerrier() : base(
        name: "Guerrier",
        description: "",
        bonus: "",
        force: 15,
        agility: 6,
        pv: 12,
        intelligence: 4,
        defence: 10,
        compatibility: "Orc",
        incompatibility: "",
        combinaisonBonus: new Dictionary<string, int>
        {
            { "PV", 2 },
            { "Force", 5 }
        },
        upgradePoints: 5
        )
    { }
}

public class Voleur : Classe
{
    public Voleur() : base(
        name: "Voleur",
        description: "",
        bonus: "",
        force: 10,
        agility: 14,
        pv: 90,
        intelligence: 6,
        defence: 6,
        compatibility: "Elfe",
        incompatibility: "Nain",
        combinaisonBonus: new Dictionary<string, int>
        {
            { "Agility", 3 },
            { "Defence", 2 }
        })
    { }
}

public class Mage : Classe
{
    public Mage() : base(
        name: "Mage",
        description: "",
        bonus: "",
        force: 4,
        agility: 6,
        pv: 80,
        intelligence: 16,
        defence: 5,
        compatibility: "",
        incompatibility: "Orc")
    { }
}

public class Tank : Classe
{
    public Tank() : base(
        name: "Tank",
        description: "",
        bonus: "",
        force: 8,
        agility: 4,
        pv: 150,
        intelligence: 4,
        defence: 16,
        compatibility: "Nain",
        incompatibility: "Elfe",
        combinaisonBonus: new Dictionary<string, int>
        {
            { "PV", 4 },
            { "Defence", 5 }
        })
    { }
}

public class Altruiste : Classe
{
    public Altruiste() : base(
        name: "Altruiste",
        description: "",
        bonus: "",
        force: 5,
        agility: 6,
        pv: 100,
        intelligence: 14,
        defence: 7,
        compatibility: "",
        incompatibility: "Demon")
    { }
}

public class Assassin : Classe
{
    public Assassin() : base(
        name: "Assassin",
        description: "",
        bonus: "",
        force: 12,
        agility: 18,
        pv: 85,
        intelligence: 6,
        defence: 5,
        compatibility: "Demon",
        incompatibility: "",
        combinaisonBonus: new Dictionary<string, int>
        {
            { "Force", 4 },
            { "Agility", 6 }
        })
    { }
}