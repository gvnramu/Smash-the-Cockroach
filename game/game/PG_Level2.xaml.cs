using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace game
{
   
    public sealed partial class PG_Level2 : Page
    {
        public PG_Level2()
        {
            this.InitializeComponent();
            Story_Arrow.Completed += Story_Arrow_Completed;
            Story_Arrow.Begin();
        }

        private void Story_Arrow_Completed(object sender, object e)
        {
            Story_Arrow.Begin();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void img_binClose_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Story_Arrow.Stop();
            img_Arrow.Visibility = Visibility.Collapsed;
            Story_ck1.Begin();
            Img_ck1.Visibility = Visibility.Visible;
            img_binClose.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(this.BaseUri, "Assets/binopen.png"));
        }

        private void Img_ck1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Story_ck1.Pause();
            Img_ck1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(this.BaseUri, "Assets/dead-cockroach.png"));
        }
    }
}
