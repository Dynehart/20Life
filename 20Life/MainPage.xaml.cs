using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
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
            P1Forest.Tapped += Element_PointerTapped;
            P1Mountain.Tapped += Element_PointerTapped;
            P1Plain.Tapped += Element_PointerTapped;
            P1Swamp.Tapped += Element_PointerTapped;
            P1Island.Tapped += Element_PointerTapped;
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

        //private void ChangeOpacity(Image SenderImage)
        //{
        //    SenderImage.Opacity = SenderImage.Opacity == 1 ? 0.2 : 1;
        //    //if (SenderImage.Opacity == 1)
        //    //{
        //    //    SenderImage.Opacity = 0.2;

        //    //}
        //    //else
        //    //{
        //    //    SenderImage.Opacity = 1;
        //    //}
        //    //P1Forest.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"/Assets/forest.png", UriKind.Relative)));
        //    //var x = e.ToString();
        //    //var dialog = new MessageDialog(x);
        //    //await dialog.ShowAsync();
        //}

        private void Element_PointerTapped(object sender, TappedRoutedEventArgs e)
        {
            Image image = sender as Image;
            image.Opacity = image.Opacity == 1 ? 0.2 : 1;
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
