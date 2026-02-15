using System.ComponentModel;
using AppRPG.User_control;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
namespace AppRPG;

public partial class MainWindow : Window
{
    public MainMenu PremierePage = new MainMenu();
    public PageCreationPersonnage CreationPersonnage = new PageCreationPersonnage();
    public PageAttributs AttributCaracter = new PageAttributs();
    public Competence Competences = new Competence();
    
    public CharacterCreationPage CharacCreationPage = new CharacterCreationPage();
    public MainWindow()
    {
        InitializeComponent();
        RootPanel.Children.Add(PremierePage);
    }

    public void ShowCharacterCreation()
    {
        RootPanel.Children.Clear();
        RootPanel.Children.Add(CharacCreationPage);
    }
    public void ShowCompetences()
    {
        RootPanel.Children.Clear();
        RootPanel.Children.Add(Competences);
    }
    public void ShowResume(Character mainCharacter)
    {
        RootPanel.Children.Clear();
        Resume CharacterResume = new Resume(mainCharacter);
        RootPanel.Children.Add(CharacterResume);
    }
}