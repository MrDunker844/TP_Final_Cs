using System.ComponentModel;
using Avalonia.Controls;
namespace AppRPG;

public partial class MainWindow : Window
{
    public PageAjoutPerso PremierePage = new PageAjoutPerso();
    public PageCreationPersonnage CreationPersonnage = new PageCreationPersonnage();
    public MainWindow()
    {
        InitializeComponent();
        RootPanel.Children.Add(PremierePage);
    }

    public void AfficherCreationPersonnage()
    {
        RootPanel.Children.Clear();
        RootPanel.Children.Add(CreationPersonnage);
    }
}