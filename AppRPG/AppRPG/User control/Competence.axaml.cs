using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;

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
        updateCharacter();
        UpdateRemainedPoints();
        UpdateRaceImage();
    }

    public void updateCharacter()
    {
        CharacterNameTextBlock.Text = "Nom : " + MainCharacter.Name;
        CharacterRaceTextBlock.Text = "Race : " + MainCharacter.SelectedRace.Name;
        CharacterClassTextBlock.Text = "Classe : " + MainCharacter.SelectedClass.Name;
        RemainedTrows.Text = "Lancers de dés restants : " + MainCharacter.DiceThrow;
        ForceTextBlock.Text = MainCharacter.Force.ToString();
        AgilityTextBlock.Text = MainCharacter.Agility.ToString();
        PVTextBlock.Text = MainCharacter.PV.ToString();
        IntelligenceTextBlock.Text = MainCharacter.Intelligence.ToString();
        DefenceTextBlock.Text = MainCharacter.Defence.ToString();
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
        updateGotoresumeButton();
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

    public void TrowDice_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (MainCharacter.DiceThrow > 0)
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            MainCharacter.DiceThrow -= 1;
            RemainedTrows.Text = "Lancers de dés restants : " + MainCharacter.DiceThrow;
            DiceImage1.Source = new Bitmap($"../../../TheAssets/image/dice{dice1}.jpg");
            DiceImage2.Source = new Bitmap($"../../../TheAssets/image/dice{dice2}.jpg");
            MainCharacter.UpgradePoints += dice1 + dice2;
            UpdateRemainedPoints();
            if (MainCharacter.DiceThrow <= 0)
            {
                TrowDice.Classes.Remove("ready");
                TrowDice.Classes.Add("unready");
            }
            else
            {
                TrowDice.Classes.Remove("unready");
                TrowDice.Classes.Add("ready");
            }
        }
    }

    private void UpdateRaceImage()
    {
        if (MainCharacter.SelectedRace != null)
        {
            string imagePath = $"../../../TheAssets/image/{MainCharacter.SelectedRace.Name}.png";
            ImageCharacter.Source = new Bitmap(imagePath);
        }
    }

    private void GoToResume(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (MainCharacter.UpgradePoints == 0 && MainCharacter.DiceThrow == 0)
        {
            if (this.VisualRoot is MainWindow mainWindow)
            {
                mainWindow.ShowResume(MainCharacter);
            }
        }
    }

    private void updateGotoresumeButton()
    {
        if (MainCharacter.UpgradePoints == 0 && MainCharacter.DiceThrow == 0)
        {
            GoToResumeButton.Classes.Remove("unready");
            GoToResumeButton.Classes.Add("ready");
        }
        else
        {
            GoToResumeButton.Classes.Remove("ready");
            GoToResumeButton.Classes.Add("unready");
        }
    }
}
