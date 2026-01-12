using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.Markup.Xaml;

namespace AppRPG;

public partial class PageCreationPersonnage : UserControl
{
    public string CaracterClass="";
    public string CaracterRace="";
    public string CaracterWeapon="";
    public string CouleurBouton = "DarkGray";
    public PageCreationPersonnage()
    {
        InitializeComponent();
        AllChooseButtonColorReset();
    }

    private void BoutonConfirmName_OnClick(object? sender, RoutedEventArgs e)
    {
        NomPersonnageCreation.Text = NomInput.Text;
    }

    private void AllChooseButtonColorReset()
    {
        ButtonColorReset(ChooseClass);
        ButtonColorReset(ChooseRace);
        ButtonColorReset(ChooseWeapon);
        ButonConfirmName.Background = Brushes.DarkGray;
        ButonConfirmCaracter.Background = Brushes.DarkGray;
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
    private void ClassColorReset()
    {
        foreach (var control in ChooseClass.Children)
        {
            if (control is Button button)
            {
                button.Background = Brushes.DarkGray;
            }
        }
    }
    private void RaceColorReset()
    {
        foreach (var control in ChooseRace.Children)
        {
            if (control is Button button)
            {
                button.Background = Brushes.DarkGray;
            }
        }
    }
    private void WeaponColorReset()
    {
        foreach (var control in ChooseWeapon.Children)
        {
            if (control is Button button)
            {
                button.Background = Brushes.DarkGray;
            }
        }
    }
    
    
    
    private void ButtonClass1_OnClick(object? sender, RoutedEventArgs e)
    {
        ClassColorReset();
        ButtonClass1.Background = Brushes.Green;
        CaracterClass = "Class1";
    }

    private void ButtonClass2_OnClick(object? sender, RoutedEventArgs e)
    {
        ClassColorReset();
        ButtonClass2.Background = Brushes.Green;
        CaracterClass = "Class";
    }

    private void ButtonClass3_OnClick(object? sender, RoutedEventArgs e)
    {
        ClassColorReset();
        ButtonClass3.Background = Brushes.Green;
        CaracterClass = "Class";
    }
    private void ButtonClass4_OnClick(object? sender, RoutedEventArgs e)
    {
        ClassColorReset();
        ButtonClass4.Background = Brushes.Green;
        CaracterClass = "Class";
    }
    private void ButtonClass5_OnClick(object? sender, RoutedEventArgs e)
    {
        ClassColorReset();
        ButtonClass5.Background = Brushes.Green;
        CaracterClass = "Class";
    }
    private void ButtonClass6_OnClick(object? sender, RoutedEventArgs e)
    {
        ClassColorReset();
        ButtonClass6.Background = Brushes.Green;
        CaracterClass = "Class6";
    }
    
    
    private void ButtonRace1_OnClick(object? sender, RoutedEventArgs e)
    {
        RaceColorReset();
        ButtonRace1.Background = Brushes.Green;
        CaracterRace = "Race1";
    }

    private void ButtonRace2_OnClick(object? sender, RoutedEventArgs e)
    {
        RaceColorReset();
        ButtonRace2.Background = Brushes.Green;
        CaracterRace = "Race";
    }

    private void ButtonRace3_OnClick(object? sender, RoutedEventArgs e)
    {
        RaceColorReset();
        ButtonRace3.Background = Brushes.Green;
        CaracterRace = "Race";
    }
    private void ButtonRace4_OnClick(object? sender, RoutedEventArgs e)
    {
        RaceColorReset();
        ButtonRace4.Background = Brushes.Green;
        CaracterRace = "Race";
    }
    private void ButtonRace5_OnClick(object? sender, RoutedEventArgs e)
    {
        RaceColorReset();
        ButtonRace5.Background = Brushes.Green;
        CaracterRace = "Race";
    }
    private void ButtonRace6_OnClick(object? sender, RoutedEventArgs e)
    {
        RaceColorReset();
        ButtonRace6.Background = Brushes.Green;
        CaracterRace = "Race";
    }
    
    
    
    private void ButtonWeapon1_OnClick(object? sender, RoutedEventArgs e)
    {
        WeaponColorReset();
        ButtonWeapon1.Background = Brushes.Green;
        CaracterWeapon = "Weapon";
    }

    private void ButtonWeapon2_OnClick(object? sender, RoutedEventArgs e)
    {
        WeaponColorReset();
        ButtonWeapon2.Background = Brushes.Green;
        CaracterWeapon = "Weapon";
    }

    private void ButtonWeapon3_OnClick(object? sender, RoutedEventArgs e)
    {
        WeaponColorReset();
        ButtonWeapon3.Background = Brushes.Green;
        CaracterWeapon = "Weapon";
    }
    private void ButtonWeapon4_OnClick(object? sender, RoutedEventArgs e)
    {
        WeaponColorReset();
        ButtonWeapon4.Background = Brushes.Green;
        CaracterWeapon = "Weapon";
    }
    private void ButtonWeapon5_OnClick(object? sender, RoutedEventArgs e)
    {
        WeaponColorReset();
        ButtonWeapon5.Background = Brushes.Green;
        CaracterWeapon = "Weapon";
    }
    private void ButtonWeapon6_OnClick(object? sender, RoutedEventArgs e)
    {
        WeaponColorReset();
        ButtonWeapon6.Background = Brushes.Green;
        CaracterWeapon = "Weapon6";
    }

    private void ButonConfirmCaracter_OnClick(object? sender, RoutedEventArgs e)
    {
        if (CaracterClass != "" && CaracterRace != "" && CaracterWeapon != "")
        {
            AllChooseButtonColorReset();
        }
        
    }
}