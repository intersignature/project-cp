using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for town.xaml
    /// </summary>
    public partial class town : Page
    {
        public town()
        {
            InitializeComponent();
        }
        public static string dir = Environment.CurrentDirectory;
        public static string name = File.ReadLines(dir + "\\data.txt").Skip(2).Take(1).First() + " ";
        public static string class_player = "";
        public static string lv_player = File.ReadLines(dir + "\\data.txt").Skip(3).Take(1).First().Split(' ')[0];
        public int num = 0;
        string GetLine(string fileName, int line)
        {
            using (var sr = new StreamReader(fileName))
            {
                for (int i = 1; i < line; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }
        }
        private void playername_Loaded(object sender, RoutedEventArgs e)
        {
            playername.Content = name;
            showclass.Content = class_player + " ";
            lvplayer.Content = "LV. " + lv_player;
            battle.class_p = class_player;
            battle.name_p = name;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            music.Play();
            
            if(class_player == "Warrior")
            {
                display.Source = new BitmapImage(new Uri(@"\res\war2.png", UriKind.Relative));
            }
            else if (class_player == "Mage")
            {
                display.Source = new BitmapImage(new Uri(@"\res\mage2.png", UriKind.Relative));
            }
            else if (class_player == "Thief")
            {
                display.Source = new BitmapImage(new Uri(@"\res\th2.png", UriKind.Relative));
            }

        }

        private void backsmith_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("blacksmith.xaml", UriKind.RelativeOrAbsolute));
        }

        private void shop_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("shop.xaml", UriKind.RelativeOrAbsolute));
        }

        private void traven_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("traven.xaml", UriKind.RelativeOrAbsolute));
        }

       

        private void shop_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            banshop.Source = new BitmapImage(new Uri(@"\res\bannershop.jpg", UriKind.Relative));
        }

        private void shop_MouseLeave(object sender, MouseEventArgs e)
        {
            banshop.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }

        private void backsmith_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            banblack.Source = new BitmapImage(new Uri(@"\res\bannerblack.jpg", UriKind.Relative));
        }

        private void backsmith_MouseLeave(object sender, MouseEventArgs e)
        {
            banblack.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }

        private void guild_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            banguild.Source = new BitmapImage(new Uri(@"\res\bannerguild.jpg", UriKind.Relative));
        }

        private void guild_MouseLeave(object sender, MouseEventArgs e)
        {
            banguild.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }


        private void traven_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            bantra.Source = new BitmapImage(new Uri(@"\res\bannertra.jpg", UriKind.Relative));
        }

        private void traven_MouseLeave(object sender, MouseEventArgs e)
        {
            bantra.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }

        private void banworld_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            banworld1.Source = new BitmapImage(new Uri(@"\res\bannerworld.jpg", UriKind.Relative));
        }

        private void banworld_MouseLeave(object sender, MouseEventArgs e)
        {
            banworld1.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }

        private void status_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("status.xaml", UriKind.RelativeOrAbsolute));
        }

        private void banworld_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("worldmap.xaml", UriKind.RelativeOrAbsolute));
        }

        private void music_MediaEnded(object sender, RoutedEventArgs e)
        {
            music.Position = TimeSpan.FromSeconds(0);
            music.Play();
        }

        private void status_MouseEnter(object sender, MouseEventArgs e)
        {
            bord.Source = new BitmapImage(new Uri(@"\res\bordclick.png", UriKind.Relative));
        }

        private void status_MouseLeave(object sender, MouseEventArgs e)
        {
            bord.Source = new BitmapImage(new Uri(@"\res\bord.png", UriKind.Relative));
        }

        private void save_MouseEnter(object sender, MouseEventArgs e)
        {
            save.Foreground = Brushes.Yellow;
        }

        private void save_MouseLeave(object sender, MouseEventArgs e)
        {
            save.Foreground = Brushes.Black;
        }

        private void mainmenu_MouseEnter(object sender, MouseEventArgs e)
        {
            mainmenu.Foreground = Brushes.Yellow;
        }

        private void mainmenu_MouseLeave(object sender, MouseEventArgs e)
        {
            mainmenu.Foreground = Brushes.Black;
        }

        private void mainmenu_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            check = 1;
           displayquestion.Source = new BitmapImage(new Uri(@"\res\questionmainmenu.png", UriKind.Relative));
           yes.Source = new BitmapImage(new Uri(@"\res\yes.png", UriKind.Relative));
            no.Source = new BitmapImage(new Uri(@"\res\no.png", UriKind.Relative));
        }
        DispatcherTimer timer = new DispatcherTimer();
        private void save_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            num = 0;
            systembackground.saveprofile();
            displayquestion.Source = new BitmapImage(new Uri(@"\res\saved.png", UriKind.Relative));
            
            timer.Tick += new EventHandler(dispatTick);
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.Start();
           

        }

        private void dispatTick(object sender, EventArgs e)
        {
            num++;
            if(num == 3)
            {
                displayquestion.Source = null;
                timer.Stop();
            }
        }

        private void count(object sender, EventArgs e)
        {
            displayquestion.Source = null;
            
        }

        private void yes_MouseEnter(object sender, MouseEventArgs e)
        {
            yes.Source = new BitmapImage(new Uri(@"\res\yesclick.png", UriKind.Relative));
        }

        private void yes_MouseLeave(object sender, MouseEventArgs e)
        {
            yes.Source = new BitmapImage(new Uri(@"\res\yes.png", UriKind.Relative));
        }
        int check = 0;
        private void no_MouseEnter(object sender, MouseEventArgs e)
        {
            if(check == 1)
            {
                no.Source = new BitmapImage(new Uri(@"\res\noclick.png", UriKind.Relative));
            }
            
        }

        private void no_MouseLeave(object sender, MouseEventArgs e)
        {
            if(check == 1)
            {
                no.Source = new BitmapImage(new Uri(@"\res\no.png", UriKind.Relative));
            }
          
        }

        private void yes_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("mainmenu.xaml", UriKind.RelativeOrAbsolute));
        }

        private void no_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(check == 1)
            {
                displayquestion.Source = null;
            yes.Source = null;
            no.Source = null;
                check = 0;
            }
            
        }

        

        private void academy_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            banaca.Source = new BitmapImage(new Uri(@"\res\banneraca.jpg", UriKind.Relative));
        }

        private void academy_MouseLeave(object sender, MouseEventArgs e)
        {
            banaca.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
        }

        

        private void academy_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("academy.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
