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
    /// Interaction logic for worldmap.xaml
    /// </summary>
    public partial class worldmap : Page
    {
        public worldmap()
        {
            InitializeComponent();
        }

        private void tear_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            mapshowtear.Source = new BitmapImage(new Uri(@"\res\TEAR.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\tagtear.png", UriKind.Relative));
        }

        private void tear_MouseLeave(object sender, MouseEventArgs e)
        {
            mapshowtear.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }

        private void jail_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            mapshowjail.Source = new BitmapImage(new Uri(@"\res\jail.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\tagjail.png", UriKind.Relative));
        }

        private void jail_MouseLeave(object sender, MouseEventArgs e)
        {
            mapshowjail.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }

        private void garve_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            mapshowgrave.Source = new BitmapImage(new Uri(@"\res\graveyard.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\taggrave.png", UriKind.Relative));
        }

        private void valley_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            mapshowvalley.Source = new BitmapImage(new Uri(@"\res\valley.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\tagvalley.png", UriKind.Relative));
        }

        private void garve_MouseLeave(object sender, MouseEventArgs e)
        {
            mapshowgrave.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }

        private void valley_MouseLeave(object sender, MouseEventArgs e)
        {
            mapshowvalley.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }

        private void tarun_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            mapshowtarun.Source = new BitmapImage(new Uri(@"\res\tarun.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\tagtarun.png", UriKind.Relative));
        }

        private void tarun_MouseLeave(object sender, MouseEventArgs e)
        {
            mapshowtarun.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }

        private void moon_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            mapshowmoon.Source = new BitmapImage(new Uri(@"\res\moonshine.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\tagmoon.png", UriKind.Relative));
        }

        private void moon_MouseLeave(object sender, MouseEventArgs e)
        {
            mapshowmoon.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }

        private void zeal_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            mapshowzeal.Source = new BitmapImage(new Uri(@"\res\zeal.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\tagzeal.png", UriKind.Relative));
        }

        private void zeal_MouseLeave(object sender, MouseEventArgs e)
        {
            mapshowzeal.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }

        private void akn_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            mapshowakn.Source = new BitmapImage(new Uri(@"\res\ank.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\tagank.png", UriKind.Relative));
        }

        private void akn_MouseLeave(object sender, MouseEventArgs e)
        {
            mapshowakn.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }

        private void outpost_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            mapshowout.Source = new BitmapImage(new Uri(@"\res\outpostwm.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\tagoutpost.png", UriKind.Relative));
        }

        private void outpost_MouseLeave(object sender, MouseEventArgs e)
        {
            mapshowout.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }

        private void ruin_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            mapshowruin.Source = new BitmapImage(new Uri(@"\res\ruin.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\tagruin.png", UriKind.Relative));
        }

        private void ruin_MouseLeave(object sender, MouseEventArgs e)
        {
            mapshowruin.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }

        private void town_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            mapshowtown.Source = new BitmapImage(new Uri(@"\res\townwp.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\tagtown.png", UriKind.Relative));
        }

        private void town_MouseLeave(object sender, MouseEventArgs e)
        {
            mapshowtown.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
            tag.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }

        private void town_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("town.xaml", UriKind.RelativeOrAbsolute));
        }

        private void worldmap1_Loaded(object sender, RoutedEventArgs e)
        {
            music.Play();
        }

        private void moon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("moonshine.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
