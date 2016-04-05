using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace projectcompro
{
    /// <summary>
    /// Interaction logic for moonshine.xaml
    /// </summary>
    public partial class moonshine : Page

    {
        public moonshine()
        {
            InitializeComponent();
        }

        

        private void door_MouseEnter(object sender, MouseEventArgs e)
        {
            door.Source = new BitmapImage(new Uri(@"\res\door open.png", UriKind.Relative));
        }

        private void door_MouseLeave(object sender, MouseEventArgs e)
        {
            door.Source = new BitmapImage(new Uri(@"\res\door back.png", UriKind.Relative));
        }

        private void door_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("town.xaml", UriKind.RelativeOrAbsolute));
        }

        private void moonstage_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(dispatTick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 50);
            timer.Start();
            music.Play();

        }
        int num = 1;
        private void dispatTick(object sender, EventArgs e)
        {
            if (num == 1)
            {
                portal1.Source = new BitmapImage(new Uri(@"\res\portal" + num + ".png", UriKind.Relative));
                num += 1;
            }
            else if (num == 2)
            {
                portal1.Source = new BitmapImage(new Uri(@"\res\portal" + num + ".png", UriKind.Relative));
                num += 1;
            }
            else if (num == 3)
            {
                portal1.Source = new BitmapImage(new Uri(@"\res\portal" + num + ".png", UriKind.Relative));
                num += 1;
            }
            else if (num == 4)
            {
                portal1.Source = new BitmapImage(new Uri(@"\res\portal" + num + ".png", UriKind.Relative));
                num += 1;
            }
            else if (num == 5)
            {
                portal1.Source = new BitmapImage(new Uri(@"\res\portal" + num + ".png", UriKind.Relative));
                num = 1;
            }
        }

        

        private void flare1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("battle.xaml", UriKind.RelativeOrAbsolute));
            Random random = new Random();
            battle.randomNumber1 = random.Next(0, 27);
            battle.randomNumber2 = random.Next(0, 26);
            battle.randomNumber3 = random.Next(0, 27);
        }

        private void flare1_MouseEnter(object sender, MouseEventArgs e)
        {
            flare1.Source = new BitmapImage(new Uri(@"\res\flare.png", UriKind.Relative));
            warpsound.Play();
        }

        private void flare1_MouseLeave(object sender, MouseEventArgs e)
        {
            flare1.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
            warpsound.Stop();
        }

        private void music_MediaEnded(object sender, RoutedEventArgs e)
        {
            music.Position = TimeSpan.FromSeconds(0);
            music.Play();
        }

        private void warpsound_MediaEnded(object sender, RoutedEventArgs e)
        {
            warpsound.Position = TimeSpan.FromSeconds(0);
            warpsound.Play();
        }
    }
}
