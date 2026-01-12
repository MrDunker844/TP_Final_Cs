namespace DefaultNamespace;

public class Classes
{
    public string Name;
    public string Description;
    public string Atout;
    public Classes(string _name, string _description, string _atout)
    {
        Name = _name;
        Description = _description;
        Atout = _atout;
    }
}
public class Guerrier : Classes{
    public Guerrier(string name) : base(
        _name: name,
        _description: "description Guerrier",
        _bonus: "bonus")
    {}
}
public class Archer : Classes{
    public Archer(string name) : base(
        _name: name,
        _description: "description Archer",
        _bonus: "bonus")
    {}
}
public class Tank : Classes{
    public Tank(string name) : base(
        _name: name,
        _description: "description Tank",
        _bonus: "bonus")
    {}
}
public class Soigneur : Classes{
    public Soigneur(string name) : base(
        _name: name,
        _description: "description Soigneur",
        _bonus: "bonus")
    {}
}
public class Guerrier : Classes{
    public Guerrier(string name) : base(
        _name: name,
        _description: "description Guerrier",
        _bonus: "bonus")
    {}
}