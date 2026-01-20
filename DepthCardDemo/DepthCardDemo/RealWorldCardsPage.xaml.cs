using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace DepthCardDemo;

public sealed partial class RealWorldCardsPage : Page
{
    public RealWorldCardsPage()
    {
        InitializeComponent();
    }

    private void BackButton_Click(object sender, RoutedEventArgs e)
    {
        if (Frame.CanGoBack)
        {
            Frame.GoBack();
        }
    }
}
