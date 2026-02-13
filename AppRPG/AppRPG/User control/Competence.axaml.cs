using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AppRPG.User_control;

public partial class Competence : UserControl
{
    public Character MainCharacter { get; set; }

    public Competence()
    {
        InitializeComponent();
    }

    public void InitializeValues()
    {
        MainCharacter = CharacterCreationPage.MainCharacter;
        CharacterNameTextBlock.Text = "Nom : " + MainCharacter.Name;
        CharacterRaceTextBlock.Text = "Race : " + MainCharacter.SelectedRace.Name;
        CharacterClassTextBlock.Text = "Classe : " + MainCharacter.SelectedClass.Name;
        RemainedTrows.Text = "Lancers de dés restants : " + MainCharacter.DiceThrow;
        ForceTextBlock.Text = MainCharacter.Force.ToString();
        AgilityTextBlock.Text = MainCharacter.Agility.ToString();
        PVTextBlock.Text = MainCharacter.PV.ToString();
        IntelligenceTextBlock.Text = MainCharacter.Intelligence.ToString();
        DefenceTextBlock.Text = MainCharacter.Defence.ToString();
        UpdateRemainedPoints();
    }

    public void AddStat(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (MainCharacter.UpgradePoints > 0)
        {
            if (sender is Button button)
            {
                string attribut = button.Name.ToString();
                switch (attribut)
                {
                    case "ForceAddButton":
                        MainCharacter.Force += 1;
                        ForceTextBlock.Text = MainCharacter.Force.ToString();
                        MainCharacter.CompetenceForce += 1;
                        MainCharacter.UpgradePoints -= 1;
                        UpdateRemainedPoints();
                        break;
                    case "AgilityAddButton":
                        MainCharacter.Agility += 1;
                        AgilityTextBlock.Text = MainCharacter.Agility.ToString();
                        MainCharacter.CompetenceAgility += 1;
                        MainCharacter.UpgradePoints -= 1;
                        UpdateRemainedPoints();
                        break;
                    case "PVAddButton":
                        MainCharacter.PV += 1;
                        PVTextBlock.Text = MainCharacter.PV.ToString();
                        MainCharacter.CompetencePV += 1;
                        MainCharacter.UpgradePoints -= 1;
                        UpdateRemainedPoints();
                        break;
                    case "IntelligenceAddButton":
                        MainCharacter.Intelligence += 1;
                        IntelligenceTextBlock.Text = MainCharacter.Intelligence.ToString();
                        MainCharacter.CompetenceIntelligence += 1;
                        MainCharacter.UpgradePoints -= 1;
                        UpdateRemainedPoints();
                        break;
                    case "DefenceAddButton":
                        MainCharacter.Defence += 1;
                        DefenceTextBlock.Text = MainCharacter.Defence.ToString();
                        MainCharacter.CompetenceDefence += 1;
                        MainCharacter.UpgradePoints -= 1;
                        UpdateRemainedPoints();
                        break;
                }
            }
        }
    }

    public void RemoveStat(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (sender is Button button)
        {
            string attribut = button.Name.ToString();
            switch (attribut)
            {
                case "ForceRemoveButton":
                    if (MainCharacter.CompetenceForce > 0)
                    {
                        MainCharacter.Force -= 1;
                        ForceTextBlock.Text = MainCharacter.Force.ToString();
                        MainCharacter.CompetenceForce -= 1;
                        MainCharacter.UpgradePoints += 1;
                        UpdateRemainedPoints();
                    }
                    break;

                case "AgilityRemoveButton":
                    if (MainCharacter.CompetenceAgility > 0)
                    {
                        MainCharacter.Agility -= 1;
                        AgilityTextBlock.Text = MainCharacter.Agility.ToString();
                        MainCharacter.CompetenceAgility -= 1;
                        MainCharacter.UpgradePoints += 1;
                        UpdateRemainedPoints();
                    }
                    break;
                case "PVRemoveButton":
                    if (MainCharacter.CompetencePV > 0)
                    {
                        MainCharacter.PV -= 1;
                        PVTextBlock.Text = MainCharacter.PV.ToString();
                        MainCharacter.CompetencePV -= 1;
                        MainCharacter.UpgradePoints += 1;
                        UpdateRemainedPoints();
                    }
                    break;
                case "IntelligenceRemoveButton":
                    if (MainCharacter.CompetenceIntelligence > 0)
                    {
                        MainCharacter.Intelligence -= 1;
                        IntelligenceTextBlock.Text = MainCharacter.Intelligence.ToString();
                        MainCharacter.CompetenceIntelligence -= 1;
                        MainCharacter.UpgradePoints += 1;
                        UpdateRemainedPoints();
                    }
                    break;
                case "DefenceRemoveButton":
                    if (MainCharacter.CompetenceDefence > 0)
                    {
                        MainCharacter.Defence -= 1;
                        DefenceTextBlock.Text = MainCharacter.Defence.ToString();
                        MainCharacter.CompetenceDefence -= 1;
                        MainCharacter.UpgradePoints += 1;
                        UpdateRemainedPoints();
                    }
                    break;
            }
        }
    }

    public void UpdateRemainedPoints()
    {
        RemainedPoints.Text = "Points de compétence restants : " + MainCharacter.UpgradePoints;
    }
}
