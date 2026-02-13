using System.Collections.Generic;
using AppRPG.Models;

public  class Character
{
    public string Name { get; set; }
    public int Force { get; set; }
    public int CompetenceForce { get; set; }
    public int Agility { get; set; }
    public int CompetenceAgility { get; set; }
    public int PV { get; set; }
    public int CompetencePV { get; set; }
    public int Intelligence { get; set; }
    public int CompetenceIntelligence { get; set; }
    public int Defence { get; set; }
    public int CompetenceDefence { get; set; }
    public Classe SelectedClass { get; set; }
    public Race SelectedRace { get; set; }
    public int UpgradePoints { get; set; }
    public int DiceThrow { get; set; }
    private Dictionary<string, int> stats = new Dictionary<string, int>();
    
    public Character(string name, Classe selected, Race race)
    {
        Name = name;
        SelectedClass = selected;
        SelectedRace = race;
        Force = selected.Force + race.Force;
        Agility = selected.Agility + race.Agility;
        PV = selected.PV + race.PV;
        Intelligence = selected.Intelligence + race.Intelligence;
        Defence = selected.Defence + race.Defence;
        UpgradePoints = selected.UpgradePoints;
        DiceThrow = 1;
        stats = new Dictionary<string, int> {
            { "Force", Force },
            { "Agility", Agility },
            { "PV", PV },
            { "Defence", Defence },
            { "Intelligence", Intelligence }};
        if (SelectedRace.Compatibility == SelectedClass.Name)
            {
                foreach (var bonus in SelectedClass.CombinaisonBonus)
                {
                foreach (var stat in stats.Keys)
                    { 
                    if (stat == bonus.Key)
                        {
                        stats[stat] += bonus.Value;
                        }
                    }
                }   
                    
            }
    }
}