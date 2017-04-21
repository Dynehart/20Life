using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _20Life
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int P1HP = 20;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void P1Plus_Click(object sender, RoutedEventArgs e)
        {
            P1HPText.Text = (++P1HP).ToString();
        }

        private void P1Minus_Click(object sender, RoutedEventArgs e)
        {
            P1HPText.Text = (--P1HP).ToString();
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {

        }

        private  void P1Forest_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChangeOpacity(P1Forest);

        }

        private void P1Mountain_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChangeOpacity(P1Mountain);

        }

        private void P1Plain_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChangeOpacity(P1Plain);

        }

        private void P1Swamp_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChangeOpacity(P1Swamp);

        }

        private void P1Island_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChangeOpacity(P1Island);

        }

        private void ChangeOpacity(Image SenderImage)
        {
            if (SenderImage.Opacity == 1)
            {
                SenderImage.Opacity = 0.2;

            }
            else
            {
                SenderImage.Opacity = 1;
            }
            //P1Forest.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"/Assets/forest.png", UriKind.Relative)));
            //var x = e.ToString();
            //var dialog = new MessageDialog(x);
            //await dialog.ShowAsync();
        }

        private void P1Minus_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(sender as Control, "HoverState", false);
        }

        private void FontIcon_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
        }

        //private void P1Plus_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    P1HPText.Text = (++P1HP).ToString();
        //}

        //private async void P1Plus_Holding(object sender, HoldingRoutedEventArgs e)
        //{
        //    P1HPText.Text = (++P1HP).ToString();
        //}

        //private void P1Plus_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        //{
        //    P1HPText.Text = (P1HP += 4).ToString();
        //}
    }
}
