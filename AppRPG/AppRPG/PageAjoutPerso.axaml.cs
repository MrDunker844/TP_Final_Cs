using System;
using System.IO;
using System.Runtime;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AppRPG;

public partial class PageAjoutPerso : UserControl
{
    
    public PageAjoutPerso()
    {
        InitializeComponent();
    }

    private void BoutonAjoutPerso_OnClick(object? sender, RoutedEventArgs e)
    {
        if (this.VisualRoot is MainWindow mainWindow)
        {
            mainWindow.AfficherCreationPersonnage();
        }

    }
}