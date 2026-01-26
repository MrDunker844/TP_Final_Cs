using System.ComponentModel;
using AppRPG.User_control;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
namespace AppRPG;

public partial class MainWindow : Window
{
    public PageAjoutPerso PremierePage = new PageAjoutPerso();
    public PageCreationPersonnage CreationPersonnage = new PageCreationPersonnage();
    public PageAttributs AttributCaracter = new PageAttributs();
    public CharacterCreationPage CharacCreationPage = new CharacterCreationPage();
    public MainWindow()
    {
        InitializeComponent();
        RootPanel.Children.Add(PremierePage);
    }

    public void AfficherCreationPersonnage()
    {
        RootPanel.Children.Clear();
        RootPanel.Children.Add(CharacCreationPage);
    }
}