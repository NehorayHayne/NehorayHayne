using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ExampleProject.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LevelsPage : Page
    {
        public LevelsPage()
        {
            this.InitializeComponent();
        }

        private void ExitImage_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MenuPage));
        }

        private void btndigit_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.BorderBrush = new SolidColorBrush(Colors.DarkRed);
        }

        private void btndigit_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.BorderBrush = new SolidColorBrush(Colors.Transparent);
        }

        private void btndigit_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MenuPage));
        }
    }
}
