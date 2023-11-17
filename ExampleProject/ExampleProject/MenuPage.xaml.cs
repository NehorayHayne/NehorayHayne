using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ExampleProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenuPage : Page
    {
        public MenuPage()
        {
            this.InitializeComponent();
        }
        private void btnExit_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            popupGrid.Visibility = Visibility.Visible;

        }
        private void ExitImage_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            ExitImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Buttons/Cross (1).png"));
            Window.Current.CoreWindow.PointerCursor = new Windows.UI.Core.CoreCursor(Windows.UI.Core.CoreCursorType.Hand, 1);
        }

        private void ExitImage_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            ExitImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Buttons/Cross (2).png"));
            Window.Current.CoreWindow.PointerCursor = new Windows.UI.Core.CoreCursor(Windows.UI.Core.CoreCursorType.Hand, 1);
        }

        private void PlayImage_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            PlayImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Buttons/Play (1).png"));
            Window.Current.CoreWindow.PointerCursor = new Windows.UI.Core.CoreCursor(Windows.UI.Core.CoreCursorType.Hand, 1);

        }

        private void PlayImage_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            PlayImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Buttons/Play (2).png"));
            Window.Current.CoreWindow.PointerCursor = new Windows.UI.Core.CoreCursor(Windows.UI.Core.CoreCursorType.Hand, 1);

        }

        private void OptionsImage_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            OptionsImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Buttons/Options (1).png"));
            Window.Current.CoreWindow.PointerCursor = new Windows.UI.Core.CoreCursor(Windows.UI.Core.CoreCursorType.Hand, 1);

        }

        private void OptionsImage_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            OptionsImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Buttons/Options (2).png"));
            Window.Current.CoreWindow.PointerCursor = new Windows.UI.Core.CoreCursor(Windows.UI.Core.CoreCursorType.Hand, 1);

        }

        private void ShopImage_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            ShopImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Buttons/Shop (1).png"));
            Window.Current.CoreWindow.PointerCursor = new Windows.UI.Core.CoreCursor(Windows.UI.Core.CoreCursorType.Hand, 1);

        }

        private void ShopImage_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            ShopImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Buttons/Shop (2).png"));
            Window.Current.CoreWindow.PointerCursor = new Windows.UI.Core.CoreCursor(Windows.UI.Core.CoreCursorType.Hand, 1);

        }

        private void TropyImage_PointerEntered(object sender, PointerRoutedEventArgs e)
        {

            TropyImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Buttons/Tropy (1).png"));
            Window.Current.CoreWindow.PointerCursor = new Windows.UI.Core.CoreCursor(Windows.UI.Core.CoreCursorType.Hand, 1);

        }

        private void TropyImage_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            TropyImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Buttons/Tropy (2).png"));
            Window.Current.CoreWindow.PointerCursor = new Windows.UI.Core.CoreCursor(Windows.UI.Core.CoreCursorType.Hand, 1);
        }
    }
}
