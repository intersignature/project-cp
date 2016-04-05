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
    /// Interaction logic for shop.xaml
    /// </summary>
    public partial class shop : Page
    {
        int check = 0;
        public shop()
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

        private void shop1_Loaded(object sender, RoutedEventArgs e)
        {
            music.Play();
            
        }

        private void sell_MouseEnter_1(object sender, MouseEventArgs e)
        {
            
            if (check == 0){
                jick.Stop();
                jick.Play();
                sell.Foreground = Brushes.Yellow;
            }
        }

        private void sell_MouseLeave(object sender, MouseEventArgs e)
        {
            sell.Foreground = Brushes.White;
        }

        private void buy_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            buy.Foreground = Brushes.Yellow;
        }

        private void buy_MouseLeave(object sender, MouseEventArgs e)
        {
            buy.Foreground = Brushes.White;
        }

        private void buy_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            check += 1;
            if (check == 1)
            {
                buy.Content = "BACK";
                sell.Content = "";
            }
            else if (check == 2)
            {
                buy.Content = " BUY";
                sell.Content = "SELL";
                check = 0;
            }
        }

        private void sell_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            check += 1;
            if (check == 1)
            {
                inventory.sell = 1;
                this.NavigationService.Navigate(new Uri("inventory.xaml", UriKind.Relative));
            }
            else if (check == 2)
            {
                buy.Content = " BUY";
                sell.Content = "SELL";
                check = 0;
            }
        }
    }
}
