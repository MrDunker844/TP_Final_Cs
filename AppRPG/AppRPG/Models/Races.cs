namespace DefaultNamespace;

public class Races
{
    public string Name;
    public string Description;
    public string Bonus;
    public Races(string _name,string _description, string _bonus){
        Name = _name;
        Description = _description;
        Bonus = _bonus;
    }
}

public class Humains : Races{
    public Humains(string name) : base(
        _name: name,
        _description: "description humains",
        _bonus: "bonus")
        {}
}

public class Elfes : Races
{
    public Elfes(string name) : base(
        _name : name,
        _description: "description elfes",
        _bonus: "bonus")
    {}
}

public class Nains : Races
{
    public Nains(string name) : base(
        _name : name,
        _description: "description nains",
        _bonus: "bonus")
    {}
}

public class Orcs : Races
{
    public Orcs(string name) : base(
        _name : name,
        _description: "description orcs",
        _bonus: "bonus")
        {}
}

public classe Dragons : Races
{
    public Dragons(string name) : base(
        _name: name,
        _description: "descritpion dragon",
        _bonus: "bonus")
        {}
}