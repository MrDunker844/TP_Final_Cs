using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;

namespace AppRPG.User_control;

public partial class CharacterCreationPage : UserControl
{
    public CharacterCreationPage()
    {
        InitializeComponent();
        ImageCharacter.Source = new Bitmap("../../../TheAssets/image/mage.png");
    }
}