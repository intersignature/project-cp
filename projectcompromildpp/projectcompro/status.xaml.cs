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

namespace projectcompro
{
    /// <summary>
    /// Interaction logic for status.xaml
    /// </summary>
    public partial class status : Page
    {
        public status()
        {
            InitializeComponent();
        }

        private void inven_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            inven.Source = new BitmapImage(new Uri(@"\res\bag open.png", UriKind.Relative));
        }

        private void inven_MouseLeave(object sender, MouseEventArgs e)
        {
            inven.Source = new BitmapImage(new Uri(@"\res\bag.png", UriKind.Relative));
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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            music.Play();
        }

        private void inven_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("inventory.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
