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


namespace game
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int c1, c2, c3, c4, c5, c6, c7,score=0,final=0;

        public MainPage()
        {
           
            this.InitializeComponent();
            //MediaElement sound = new MediaElement();
            //sound.AudioCategory = Windows.UI.Xaml.Media.AudioCategory.BackgroundCapableMedia;
            //StorageFolder folder = await Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Story_Arrow.Begin();
            Story_Arrow.Completed += Story_Arrow_Completed;
            Storyboard1.Completed += Storyboard1_Completed;
            Storyboard2.Completed += Storyboard1_Completed;
            Storyboard3.Completed += Storyboard1_Completed;
            Story_ck3.Completed += Storyboard1_Completed;
            Story_ck4.Completed += Storyboard1_Completed;
            Story_ck5.Completed += Storyboard1_Completed;
            Story_ck6.Completed += Storyboard1_Completed;

        }
        void Story_Arrow_Completed(object sender, object e)
        {
            Story_Arrow.Begin();
        }

        void Storyboard1_Completed(object sender, object e)
        {
            lady.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(this.BaseUri, "Assets/fear.png"));
            final = 1;
            Media_shout.Play();

            Storyboard1.Pause();
            Storyboard2.Pause();
            Storyboard3.Pause();
            Story_ck3.Pause();
            Story_ck4.Pause();
            Story_ck5.Pause();
            Story_ck6.Pause();
         
            TxtBox_gameOver.Visibility = Visibility.Visible;
            Btn_Retry.Visibility = Visibility.Visible;
        }
        //void Storyboard2_Completed(object sender, object e)
        //{
        //    lady.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(this.BaseUri, "Assets/fear.png"));
        //}

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           
        }
        int s = 0;
        private void binclose_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Story_Arrow.Pause();
            Img_Arrow.Visibility = Visibility.Collapsed;
            if (s == 0)
            {
                binclose.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(this.BaseUri, "Assets/binopen.png"));
                Storyboard1.Begin();
                Storyboard2.Begin();
                ck1.Visibility = Visibility.Visible;
                cockroach.Visibility = Visibility.Visible;
                s = 1;
            }
        }
        int h = 0;
        private void cockroach_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if ((h == 0) && (final == 0))
            {
                TxtBox_Scoreint.Text = Convert.ToString(score = score + 1);
                c1 = 1;
                cockroach.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(this.BaseUri, "Assets/dead-cockroach.png"));
                Storyboard1.Pause();
                h = 1;
            }
        }

        int control = 0;
        private void ck1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            c2 = 1;
           
            if ((control == 0) && (final == 0))
            {
                TxtBox_Scoreint.Text = Convert.ToString(score = score + 1); 
                ck1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(this.BaseUri, "Assets/dead-cockroach.png"));
                Storyboard2.Pause();
                Storyboard3.Begin();
                ck2.Visibility = Visibility.Visible;
                control = 1;
            }
        }
        int b = 0;
        private void ck2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            c3 = 1;

            if ((b == 0) && (final == 0))
            {
                TxtBox_Scoreint.Text = Convert.ToString(score = score + 1); 
                ck2.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(this.BaseUri, "Assets/dead-cockroach.png"));
                Storyboard3.Pause();
                Story_ck3.Begin();
                ck3.Visibility = Visibility.Visible;
                b = 1;
            }
        }
        int c = 0;
        private void ck3_Tapped(object sender, TappedRoutedEventArgs e)
        {
           
            c4 = 1;
            if ((c == 0) && (final == 0))
            {
                TxtBox_Scoreint.Text = Convert.ToString(score = score + 1); 
                ck3.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(this.BaseUri, "Assets/dead-cockroach.png"));
                Story_ck3.Pause();
               // if (c3 == 0)
                {
                    Story_ck4.Begin();

                    ck4.Visibility = Visibility.Visible;
                }
                c = 1;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PG_Start));
        }

        int d = 0;
        private void ck4_Tapped(object sender, TappedRoutedEventArgs e)
        {
          
            c5 = 1;
            if ((d == 0) && (final == 0))
            {
                TxtBox_Scoreint.Text = Convert.ToString(score = score + 1); 
                ck4.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(this.BaseUri, "Assets/dead-cockroach.png"));
                Story_ck4.Pause();
                Story_ck6.Begin();
                ck6.Visibility = Visibility.Visible;
                Story_ck5.Begin();
                ck5.Visibility = Visibility.Visible;
                d = 1;
            }
            if ((c1 == 1) && (c2 == 1) && (c3 == 1) && (c4 == 1) && (c5 == 1) && (c6 == 1) && (c7 == 1))
            {
                Btn_Level2.Visibility = Visibility.Visible;
                TxtBox_congrats.Visibility = Visibility.Visible;
                Storyboard1.Pause();
                Storyboard2.Pause();
                Storyboard3.Pause();
                Story_ck3.Pause();
                Story_ck4.Pause();
                Story_ck5.Pause();
                Story_ck6.Pause();

            }
        }
        int f= 0;
        private void ck5_Tapped(object sender, TappedRoutedEventArgs e)
        {
           
            c6 = 1;

            if((f == 0) && (final == 0))
            {
                TxtBox_Scoreint.Text = Convert.ToString(score = score + 1); 
                ck5.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(this.BaseUri, "Assets/dead-cockroach.png"));
                Story_ck5.Pause();
                if ((c1 == 1) && (c2 == 1) && (c3 == 1) && (c4 == 1) && (c5 == 1) && (c6 == 1) && (c7 == 1))
                {
                    Btn_Level2.Visibility = Visibility.Visible;
                    TxtBox_congrats.Visibility = Visibility.Visible;
                    Storyboard1.Pause();
                    Storyboard2.Pause();
                    Storyboard3.Pause();
                    Story_ck3.Pause();
                    Story_ck4.Pause();
                    Story_ck5.Pause();
                    Story_ck6.Pause();
                }
                f = 1;
            }
        }
        int g = 0;
        private void ck6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            c7 = 1;
            if ((g == 0) && (final == 0))
            {
                TxtBox_Scoreint.Text = Convert.ToString(score = score + 1);
                ck6.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(this.BaseUri, "Assets/dead-cockroach.png"));
                Story_ck6.Pause();
                g = 1;
            }
            if ((c1 == 1) && (c2==1) && (c3==1) && (c4==1) && (c5==1) && (c6==1) && (c7==1))
            {
                Btn_Level2.Visibility = Visibility.Visible;
                TxtBox_congrats.Visibility = Visibility.Visible;
                Storyboard1.Pause();
                Storyboard2.Pause();
                Storyboard3.Pause();
                Story_ck3.Pause();
                Story_ck4.Pause();
                Story_ck5.Pause();
                Story_ck6.Pause();
            }
        }

        private void Btn_Retry_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
              
           
        }
        private void Btn_Level2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PG_Level2));
        }

        
    }
}
