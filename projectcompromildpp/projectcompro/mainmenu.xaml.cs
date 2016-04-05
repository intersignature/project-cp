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

namespace projectcompro
{
    /// <summary>
    /// Interaction logic for mainmenu.xaml
    /// </summary>
    public partial class mainmenu : Page
    {
        public static string dir = Environment.CurrentDirectory;

        public mainmenu()
        {
            InitializeComponent();

        }





        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            music.Play();
        }

        private void start_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            start.Source = new BitmapImage(new Uri(@"\res\startgamec.png", UriKind.Relative));
        }

        private void start_MouseLeave(object sender, MouseEventArgs e)
        {
            start.Source = new BitmapImage(new Uri(@"\res\startgame.png", UriKind.Relative));
        }

        private void conti_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            conti.Source = new BitmapImage(new Uri(@"\res\contic.png", UriKind.Relative));
        }

        private void conti_MouseLeave(object sender, MouseEventArgs e)
        {
            conti.Source = new BitmapImage(new Uri(@"\res\conti.png", UriKind.Relative));
        }

        private void exbup_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            exit.Source = new BitmapImage(new Uri(@"\res\exitdown.png", UriKind.Relative));
        }
        string GetLine(string fileName, int line)
        {
            using (var sr = new StreamReader(fileName))
            {
                for (int i = 1; i < line; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }
        }
        int check = 0;
        private void start_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (File.ReadLines(dir + "\\data.txt").Skip(0).Take(1).First() == "1")
            {
                check = 1;
                question.Source = new BitmapImage(new Uri(@"\res\newqustion.png", UriKind.Relative));
                yes.Source = new BitmapImage(new Uri(@"\res\yes.png", UriKind.Relative));
                no.Source = new BitmapImage(new Uri(@"\res\no.png", UriKind.Relative));
            }
            else
            {
                this.NavigationService.Navigate(new Uri("select.xaml", UriKind.RelativeOrAbsolute));
            }

        }

        private void exbdown_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            exit.Source = new BitmapImage(new Uri(@"\res\exitup.png", UriKind.Relative));
        }

        

        private void yes_MouseEnter(object sender, MouseEventArgs e)
        {
            if (check == 1)
            {
                yes.Source = new BitmapImage(new Uri(@"\res\yesclick.png", UriKind.Relative));
            }
        }

        private void yes_MouseLeave(object sender, MouseEventArgs e)
        {
            if (check == 1)
            {
                yes.Source = new BitmapImage(new Uri(@"\res\yes.png", UriKind.Relative));
            }
        }

        private void no_MouseEnter(object sender, MouseEventArgs e)
        {
            if (check == 1)
            {
                no.Source = new BitmapImage(new Uri(@"\res\noclick.png", UriKind.Relative));
            }
        }

        private void no_MouseLeave(object sender, MouseEventArgs e)
        {
            if (check == 1)
            {
                no.Source = new BitmapImage(new Uri(@"\res\no.png", UriKind.Relative));
            }
        }

        private void yes_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (check == 1)
            {
                this.NavigationService.Navigate(new Uri("select.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void no_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (check == 1)
            {
                check = 0;
                question.Source = null;
                yes.Source = null;
                no.Source = null;


            }

        }

        
        
        
        private void conti_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int i = 0;
            string strline = null;
            FileStream fr = new FileStream(dir + "\\data.txt", FileMode.Open);
            StreamReader str = new StreamReader(fr);
            while (str.Peek() != -1)
            {

                strline = str.ReadLine();
                i += 1;
                if (i == 1)
                {
                    break;
                }
            }
            i = 0;
            fr.Close();
            check = 1;
            if (strline == "0")
            {
                if (check == 1)
                {
                    question.Source = new BitmapImage(new Uri(@"\res\continue.png", UriKind.Relative));
                    continue_ok.Source = new BitmapImage(new Uri(@"\res\krub.png", UriKind.Relative));
                }
            }
            else if (strline == "1")
            {
                this.NavigationService.Navigate(new Uri("town.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void continue_ok_MouseEnter_1(object sender, MouseEventArgs e)
        {
            if (check == 1)
                continue_ok.Source = new BitmapImage(new Uri(@"\res\krubclick.png", UriKind.Relative));
        }

        private void continue_ok_MouseLeave_1(object sender, MouseEventArgs e)
        {
            if (check == 1)
            {
                continue_ok.Source = new BitmapImage(new Uri(@"\res\krub.png", UriKind.Relative));
            }
        }

        private void continue_ok_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            continue_ok.Source = null;
            question.Source = null;
            check = 0;
        }
    }
}
