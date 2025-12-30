using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AppRPG;

public partial class PageCreationPersonnage : UserControl
{
    public PageCreationPersonnage()
    {
        InitializeComponent();
    }

    private void BoutonValiderNom_OnClick(object? sender, RoutedEventArgs e)
    {
        NomPersonnageCreation.Text = NomInput.Text;
    }
}