using System.ComponentModel;
using Avalonia.Controls;
namespace AppRPG;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        PageAjoutPerso PremierePage = new PageAjoutPerso();
        RootPanel.Children.Add(PremierePage);
    }
}