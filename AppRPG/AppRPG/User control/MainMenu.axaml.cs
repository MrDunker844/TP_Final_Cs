using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AppRPG.User_control;

public partial class MainMenu : UserControl
{
    public MainMenu()
    {
        InitializeComponent();
    }

    private void GoToCreation(object? sender, RoutedEventArgs e)
    {
        if (this.VisualRoot is MainWindow mainWindow)
        {
            mainWindow.ShowCharacterCreation();
        }
    }
}