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
    /// Interaction logic for academy.xaml
    /// </summary>
    public partial class academy : Page
    {
        public academy()
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
    }
}
