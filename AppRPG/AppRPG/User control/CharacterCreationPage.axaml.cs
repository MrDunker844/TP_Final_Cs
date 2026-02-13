using System;
using AppRPG.Models;
using Avalonia;
using Avalonia.Controls;
using System.Collections.Generic;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using Avalonia.Media;
using Avalonia.Interactivity;
using System.Linq;


namespace AppRPG.User_control;

public partial class CharacterCreationPage : UserControl
{
    private readonly Dictionary<string, Func<Race>> raceFactory = //idée de factory trouver grace a l'ia
    new Dictionary<string, Func<Race>>{
        { "Humain", () => new Humain() },
        { "Elfe", () => new Elfe() },
        { "Orc", () => new Orc() },
        { "Dragon", () => new Dragon() },
        { "Démon", () => new Demon() },
        { "Nain", () => new Nain() }
    };
    private readonly Dictionary<string, Func<Classe>> classFactory =
    new Dictionary<string, Func<Classe>>{
        { "Guerrier", () => new Guerrier() },
        { "Voleur", () => new Voleur() },
        { "Mage", () => new Mage() },
        { "Tank", () => new Tank() },
        { "Altruiste", () => new Altruiste() },
        { "Assassin", () => new Assassin() }
    };
    private Dictionary<string, int> stats = new Dictionary<string, int>
    {
            { "Force", 0 },
            { "Agility", 0 },
            { "PV", 0 },
            { "Defence", 0 },
            { "Intelligence", 0 }
    };

    private Race choosedRace;
    private Classe choosedClass;
    public static Character MainCharacter;
    public CharacterCreationPage()
    {
        InitializeComponent();
        ImageCharacter.Source = new Bitmap("../../../TheAssets/image/UnChoosed.png");
    }
    public void OnRaceButtonClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (sender is Button button)
        {
            string raceName = button.Content.ToString();
            if (raceFactory.TryGetValue(raceName, out var raceConstructor))
            {
                choosedRace = raceConstructor();
                if (choosedRace.Incompatibility == choosedClass?.Name)
                {
                    InformationBox.Text = $"Le choix de la Race {choosedRace.Name} est incompatible avec la classe {choosedClass.Name}.";
                    choosedRace = null;
                }
                else
                {
                    updateStats();
                    updateVisualAttribute();
                    ButtonColorReset(RaceGrid);
                    button.Background = Brushes.DarkGreen;
                    updateFinalButton();
                    InformationBox.Text = "";
                }
            }
        }
        UpdateRaceImage();
    }
    public void OnClassButtonClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (sender is Button button)
        {
            string className = button.Content.ToString();
            if (classFactory.TryGetValue(className, out var classConstructor))
            {
                choosedClass = classConstructor();
                if (choosedClass.Incompatibility == choosedRace?.Name)
                {
                    InformationBox.Text = $"Le choix de la classe {choosedClass.Name} est incompatible avec la race {choosedRace.Name}.";
                    choosedClass = null;
                }
                else
                {
                    updateStats();
                    updateVisualAttribute();
                    ButtonColorReset(ClassGrid);
                    button.Background = Brushes.DarkGreen;
                    updateFinalButton();
                    InformationBox.Text = "";
                }
            }
        }
    }

    public void updateVisualAttribute()
    {
        if (choosedRace != null&& choosedClass != null)//
        {
            ForceTextBlock.Text = $"Force : {stats["Force"]}";//
            AgilityTextBlock.Text = $"Agilité : {stats["Agility"]}";//
            PVTextBlock.Text = $"PV : {stats["PV"]}";//
            DefenceTextBlock.Text = $"Defence : {stats["Defence"]}";//
            IntelligenceTextBlock.Text = $"Intelligence : {stats["Intelligence"]}";//
        }
    }
    private void ButtonColorReset(Grid Name)
    {
        foreach (var control in Name.Children)
        {
            if (control is Button button)
            {
                button.Background = Brushes.DarkGray;
            }
        }
    }
    private void ButonConfirmName_OnClick(object? sender, RoutedEventArgs e)
    {
        CharacterNameTextBlock.Text = NameInput.Text;
        updateFinalButton();
    }
    private void updateStats()
    {
        if (choosedRace != null && choosedClass != null)
        {
            stats["Force"] = choosedRace.GetForce() + choosedClass.GetForce();
            stats["Agility"] = choosedRace.GetAgility() + choosedClass.GetAgility();
            stats["PV"] = choosedRace.GetPV() + choosedClass.GetPV();
            stats["Defence"] = choosedRace.GetDefence() + choosedClass.GetDefence();
            stats["Intelligence"] = choosedRace.GetIntelligence() + choosedClass.GetIntelligence();
            if (choosedRace.Compatibility == choosedClass.Name)
            {
                foreach (var bonus in choosedClass.CombinaisonBonus)
                {
                    stats[bonus.Key] += bonus.Value;
                }
                BonusTextBlock.Text = $"Bonus de combinaison : {string.Join(", ", choosedClass.CombinaisonBonus.Select(b => $"{b.Key} +{b.Value}"))}";
            }
            else
            {
                BonusTextBlock.Text = "Aucun bonus de combinaison.";
            }
        }
    }

    private void updateFinalButton()
    {
        if (choosedRace != null && choosedClass != null && CharacterNameTextBlock.Text != "Nom par défaut" && CharacterNameTextBlock.Text != "")
        {
            StartAdventureButton.Classes.Remove("unready");
            StartAdventureButton.Classes.Add("ready");
        }
        else
        {
            StartAdventureButton.Classes.Remove("ready");
            StartAdventureButton.Classes.Add("unready");
        }
    }
    private void OnStartAdventureButtonClick(object sender, RoutedEventArgs e)
    {
        if (choosedRace != null && choosedClass != null && CharacterNameTextBlock.Text != "Nom par défaut" && CharacterNameTextBlock.Text != "")
        {
            MainCharacter = new Character(CharacterNameTextBlock.Text, choosedClass, choosedRace);


            if (this.VisualRoot is MainWindow mainWindow)
            {
                mainWindow.AfficherCompetences();
                mainWindow.Competences.InitializeValues();
            }


        }
    }
    private Character GetMainCharacter()
    {
        return MainCharacter;
    }
    private void UpdateRaceImage()
    {
        if (choosedRace != null)
        {
            string imagePath = $"../../../TheAssets/image/{choosedRace.Name}.png";
            ImageCharacter.Source = new Bitmap(imagePath);
        }
    }
}
