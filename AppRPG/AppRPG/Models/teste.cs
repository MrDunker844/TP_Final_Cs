public class Game
{
    public static void Main()
    {
        Perso.Assassin Perso1 = new Perso.Assassin("Shuriken");
        Items.HealPotion Potion1 = new Items.HealPotion();
        Perso1.PresentationPerso();
        Potion1.DescriptionItems();
    }
    
}

// ---------------------------------------------------------------------------------------------------

// Classe personnage
public class Perso {
    public string Name; 
    public string TypeOfPerso; 
    public string Description; 
    public int PowerMax;
    public int PowerCurrent; 
    public int LifeMax;
    public int LifeCurrent;
    public string Creator;
    public int LevelMax;
    public int LevelCurrent;
    public int EnduranceMax;
    public int EnduranceCurrent;
// Constructeur OK
    public Perso(string _name, string _typeOfPerso, string _description, int _powerMax, int _powerCurrent, 
        int _lifeMax, int _lifeCurrent, string _creator, int _levelMax, int _levelCurrent, int _enduranceMax, int _enduranceCurrent) {
        Name = _name;
        TypeOfPerso = _typeOfPerso;
        Description = _description;
        PowerMax = _powerMax;
        PowerCurrent = _powerCurrent;
        LifeMax = _lifeMax;
        LifeCurrent = _lifeCurrent;
        Creator = _creator;
        LevelMax = _levelMax;
        LevelCurrent = _levelCurrent;
        EnduranceMax = _enduranceMax;
        EnduranceCurrent = _enduranceCurrent; }
// Types de perso OK
    public class Guerrier : Perso{
        public Guerrier(string name) : base(
            _name: name,
            _typeOfPerso: "Guerrier",
            _description: "Un combattant puissant.",
            _powerMax: 80,
            _powerCurrent: 80,
            _lifeMax: 150, 
            _lifeCurrent: 150, 
            _creator: "", 
            _levelMax: 50, 
            _levelCurrent: 1, 
            _enduranceMax: 120, 
            _enduranceCurrent: 120){}}
    public class Archer : Perso{
            public Archer(string name) : base(
                _name: name,
                _typeOfPerso: "Archer",
                _description: "Un combattant rapide et précis.",
                _powerMax: 70,
                _powerCurrent: 70,
                _lifeMax: 110,
                _lifeCurrent: 110,
                _creator: "",
                _levelMax: 50,
                _levelCurrent: 1,
                _enduranceMax: 140,
                _enduranceCurrent: 140
            )
            {
            }
        }

    public class Mage : Perso{
            public Mage(string name) : base(
                _name: name,
                _typeOfPerso: "Mage",
                _description: "Lanceur de sorts puissant mais physiquement fragile.",
                _powerMax: 120,
                _powerCurrent: 120,
                _lifeMax: 80,
                _lifeCurrent: 80,
                _creator: "",
                _levelMax: 50,
                _levelCurrent: 1,
                _enduranceMax: 90,
                _enduranceCurrent: 90
            )
            {
            }
        }

    public class Paladin : Perso{
            public Paladin(string name) : base(
                _name: name,
                _typeOfPerso: "Paladin",
                _description: "Protecteur sacré combinant force et magie légère.",
                _powerMax: 90,
                _powerCurrent: 90,
                _lifeMax: 140,
                _lifeCurrent: 140,
                _creator: "",
                _levelMax: 50,
                _levelCurrent: 1,
                _enduranceMax: 110,
                _enduranceCurrent: 110
            )
            {
            }
        }

    public class Tank : Perso{
            public Tank(string name) : base(
                _name: name,
                _typeOfPerso: "Tank",
                _description: "Guerrier lourdement armuré, spécialisé dans l'absorption des dégâts.",
                _powerMax: 10,
                _powerCurrent: 100,
                _lifeMax: 190,
                _lifeCurrent: 190,
                _creator: "",
                _levelMax: 50,
                _levelCurrent: 1,
                _enduranceMax: 70,
                _enduranceCurrent: 70
            )
            {
            }
        }
        
    public class Assassin : Perso
        {
            public Assassin(string name) : base(
                _name: name,
                _typeOfPerso: "Assassin",
                _description: "Expert en attaques furtives et coups critiques.",
                _powerMax: 100,
                _powerCurrent: 100,
                _lifeMax: 90,
                _lifeCurrent: 90,
                _creator: "",
                _levelMax: 50,
                _levelCurrent: 1,
                _enduranceMax: 130,
                _enduranceCurrent: 130
            ){}

        }
    
// fonctions perso
    public override void PresentationPerso(){    
        base.PresentationPerso();
        Console.WriteLine("Personnage de type : " + TypeOfPerso);
        }            
    public virtual void PresentationPerso(){
        Console.Write("-- Présentation du personnage --");
        Console.Write("\n- Nom : " + Name);
        Console.Write("\n- Type de personnage : " + TypeOfPerso);
        Console.Write("\n- Description : " + Description);
        Console.Write("\n- Puissance Max / puissance actuelle : " + PowerMax + " / " + PowerCurrent);
        Console.Write("\n- Point de vie maximal / point de vie actuelle : " + LifeMax + " / " + LifeCurrent);
        Console.Write("\n- Niveaux maximal / niveaux actuelle : " + LevelMax + " / " + LevelCurrent);
        Console.Write("\n- Endurance maximel / endurance actuelle : " + EnduranceMax + " / " + EnduranceCurrent);
        Console.Write("\n- Createur : " + Creator);
        }
// Pas faites
    public void CreationPerso(){
        Console.Write("-- Creation du creation --");
        }
}

// ---------------------------------------------------------------------------------------------------

// Classe races

public class Races{
    public string Name;
    public string Description;
}

// ---------------------------------------------------------------------------------------------------

// Classe items
public class Items
{
    public string Name;
    public string Description;
    public int DurabilityMax;
    public int  DurabilityCurrent;
    public int Rarity;
// Constructeur
    public Items(string _name, string _description, int _durabilityMax, int  _durabilityCurrent, int _rarity){
        Name = _name;
        Description = _description;
        DurabilityMax = _durabilityMax;
        DurabilityCurrent = _durabilityCurrent;
        Rarity = _rarity;}
// Types d'items
    public class HealPotion : Items{
        public HealPotion() : base(
            _name: "Potion de soin",
            _description: "Potion de soin , restaure 25 point de vie.",
            _durabilityMax: 3,
            _durabilityCurrent: 3,
            _rarity: 2){}
        public override void DescriptionItems(){ 
            base.DescriptionItems(); 
            Console.WriteLine("\n---Fin description : Potion de soin---");
        }
    }
    
    public class StrengthPotion : Items{
        public StrengthPotion() : base(
            _name: "Heal Potion",
            _description: "Potion de force , augmente de 10 % la force.",
            _durabilityMax: 3,
            _durabilityCurrent: 3,
            _rarity: 3){}
        public override void DescriptionItems(){ 
            base.DescriptionItems(); 
            Console.WriteLine("\n---Fin description : Potion de force---");
        }
    }
// fonctions items
    public virtual void DescriptionItems(){
        Console.Write("-- Description Items --");
        Console.WriteLine("\n- Nom de l'object : " + Name);
        Console.WriteLine("\n- Description : "+Description);
        Console.WriteLine("\n- Durabilité maximum / durabilité actuelle : "+DurabilityMax+" / "+DurabilityCurrent);
        Console.WriteLine("\n- Rareté : "+Rarity);}
}

// ---------------------------------------------------------------------------------------------------

// Classe armes
public class Weapons
{
    public string Name;
    public string Description;
    public int Damage;
    public int DurabilityMax;
    public int DurabilityCurrent;
    public int Rarity;
// Constructeur
    public Weapons(string _name, string _description, int _damage, int _durabilityMax, int _durabilityCurrent, int _rarity){
        Name = _name;
        Description = _description;
        Damage = _damage;
        DurabilityMax = _durabilityMax;
        DurabilityCurrent = _durabilityCurrent;
        Rarity = _rarity;}

// Types d'armes
    public class Sword : Weapons{
        public Sword() : base(
            _name: "Épée",
            _description: "Une épée tranchante en acier.",
            _damage: 50,
            _durabilityMax: 100,
            _durabilityCurrent: 100,
            _rarity: 3){}}
    public class Bow : Weapons{
        public Bow() : base(
            _name: "Arc",
            _description: "Un arc en bois robuste.",
            _damage: 40,
            _durabilityMax: 80,
            _durabilityCurrent: 80,
            _rarity: 2){}}
    public class Staff : Weapons{
        public Staff() : base(
            _name: "Bâton",
            _description: "Un bâton magique ancien.",
            _damage: 60,
            _durabilityMax: 70,
            _durabilityCurrent: 70,
            _rarity: 4){}}
    public class Dagger : Weapons{
        public Dagger() : base(
            _name: "Dague",
            _description: "Une dague légère et rapide.",
            _damage: 30,
            _durabilityMax: 60,
            _durabilityCurrent: 60,
            _rarity: 2){}}
    public class Axe : Weapons{
        public Axe() : base(
            _name: "Hache",
            _description: "Une hache lourde et puissante.",
            _damage: 70,
            _durabilityMax: 90,
            _durabilityCurrent: 90,
            _rarity: 3){}}
    public class Mace : Weapons{
        public Mace() : base(
            _name: "Masse",
            _description: "Une masse contondante en métal.",
            _damage: 65,
            _durabilityMax: 85,
            _durabilityCurrent: 85,
            _rarity: 3){}}

// fonctions armes
    public void DescriptionWeapons(){
        Console.Write("-- Description Weapons --");
        Console.WriteLine("\n- Nom de l'arme : " + Name);
        Console.WriteLine("\n- Description : "+Description);
        Console.WriteLine("\n- Dégâts : "+Damage);
        Console.WriteLine("\n- Durabilité maximum / durabilité actuelle : "+DurabilityMax+" / "+DurabilityCurrent);
        Console.WriteLine("\n- Rareté : "+Rarity);}
}