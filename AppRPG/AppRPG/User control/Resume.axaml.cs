using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using MainWindow = AppRPG.MainWindow;

namespace AppRPG.User_control;

public partial class Resume : UserControl
{
    public Character MainCharacter { get; set; }

    public Resume(Character mainCharacter)
    {
        InitializeComponent();
        MainCharacter = mainCharacter;
        UpdateRaceImage();
        updateCharacter();
        updateResume();
        updateItem();
    }

    private void UpdateRaceImage()
    {
        if (MainCharacter.SelectedRace != null)
        {
            string imagePath = $"../../../TheAssets/image/{MainCharacter.SelectedRace.Name}.png";
            CharacterImage.Source = new Bitmap(imagePath);
        }
    }

    public void updateCharacter()
    {
        CharacterName.Text = "Nom : " + MainCharacter.Name;
        CharacterRaceAndClass.Text =
            "Race : "
            + MainCharacter.SelectedRace.Name
            + " ; Classe : "
            + MainCharacter.SelectedClass.Name;
        ForceTextBlock.Text = "Force : " + MainCharacter.Force.ToString();
        AgilityTextBlock.Text = "Agilité : " + MainCharacter.Agility.ToString();
        PVTextBlock.Text = "Points de vie : " + MainCharacter.PV.ToString();
        IntelligenceTextBlock.Text = "Intelligence : " + MainCharacter.Intelligence.ToString();
        DefenceTextBlock.Text = "Défense : " + MainCharacter.Defence.ToString();
    }

    public void updateResume()
    {
        ResumeTextBlock.Text =
            $"Vous avez choisi la race {MainCharacter.SelectedRace.Name} : {MainCharacter.SelectedRace.Description} \n"
            + $"Votre classe {MainCharacter.SelectedClass.Name} : {MainCharacter.SelectedClass.Description}. \n"
            + $"Votre potion de classe est : {MainCharacter.SelectedClass.Potion.Name} et sa rareté est : {MainCharacter.SelectedClass.Potion.Rarity}.";
    }

    public void updateItem()
    {
        ItemRarityBorder.BorderBrush = MainCharacter.SelectedClass.Potion.Rarity switch
        {
            "Commun" => Brushes.Gray,
            "Rare" => Brushes.Blue,
            "Épique" => Brushes.Purple,
            "Légendaire" => Brushes.Orange,
            _ => Brushes.Transparent,
        };
        ItemImage.Source = new Bitmap(
            $"../../../TheAssets/image/{MainCharacter.SelectedClass.Potion.Name}.png"
        );
    }
}
