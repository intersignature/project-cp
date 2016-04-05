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
    /// Interaction logic for select.xaml
    /// </summary>
    public partial class select : Page
    {
        public static string dir = Environment.CurrentDirectory;
        public select()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            music.Play();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(dispatTick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 200);
            timer.Start();
        }
        int status = 1;
        int warriror_status = 0;
        int mage_status = 0;
        int theif_status = 0;
        private void dispatTick(object sender, EventArgs e)
        {
            if (warriror_status == 1)
            {
                if (status == 1)
                {
                    war.Source = new BitmapImage(new Uri(@"\res\war2.png", UriKind.Relative));

                    status++;
                }
                else if (status == 2)
                {
                    war.Source = new BitmapImage(new Uri(@"\res\war3.png", UriKind.Relative));

                    status++;
                }
                else if (status == 3)
                {
                    war.Source = new BitmapImage(new Uri(@"\res\war2.png", UriKind.Relative));

                    status++;
                }
                else
                {
                    war.Source = new BitmapImage(new Uri(@"\res\war1.png", UriKind.Relative));

                    status = 1;
                }
            }
            else if (mage_status == 1)
            {
                if (status == 1)
                {
                    mage.Source = new BitmapImage(new Uri(@"\res\mage2.png", UriKind.Relative));

                    status++;
                }
                else if (status == 2)
                {
                    mage.Source = new BitmapImage(new Uri(@"\res\mage3.png", UriKind.Relative));

                    status++;
                }
                else if (status == 3)
                {
                    mage.Source = new BitmapImage(new Uri(@"\res\mage2.png", UriKind.Relative));

                    status++;
                }
                else
                {
                    mage.Source = new BitmapImage(new Uri(@"\res\mage1.png", UriKind.Relative));

                    status = 1;
                }
            }
            else if(theif_status == 1)
            {
                if (status == 1)
                {
                    thi.Source = new BitmapImage(new Uri(@"\res\th2.png", UriKind.Relative));

                    status++;
                }
                else if (status == 2)
                {
                    thi.Source = new BitmapImage(new Uri(@"\res\th3.png", UriKind.Relative));

                    status++;
                }
                else if (status == 3)
                {
                    thi.Source = new BitmapImage(new Uri(@"\res\th2.png", UriKind.Relative));

                    status++;
                }
                else
                {
                    thi.Source = new BitmapImage(new Uri(@"\res\th1.png", UriKind.Relative));

                    status = 1;
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            walk.Stop();
            walk.Play();
            globalvariables.sentvar[2] = 0.ToString();
            warriror_status = 1;
            mage_status = 0;
            theif_status = 0;
            thi.Source = new BitmapImage(new Uri(@"\res\th2.png", UriKind.Relative));
            mage.Source = new BitmapImage(new Uri(@"\res\mage2.png", UriKind.Relative));


        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            walk.Stop();
            walk.Play();
            globalvariables.sentvar[2] = 1.ToString();
            warriror_status = 0;
            mage_status = 1;
            theif_status = 0;
            thi.Source = new BitmapImage(new Uri(@"\res\th2.png", UriKind.Relative));
            war.Source = new BitmapImage(new Uri(@"\res\war2.png", UriKind.Relative));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            walk.Stop();
            walk.Play();
            globalvariables.sentvar[2] = 2.ToString();
            warriror_status = 0;
            mage_status = 0;
            theif_status = 1;
            war.Source = new BitmapImage(new Uri(@"\res\war2.png", UriKind.Relative));
            mage.Source = new BitmapImage(new Uri(@"\res\mage2.png", UriKind.Relative));
        }

        private void txtname_TextChanged(object sender, TextChangedEventArgs e)
        {
            
       
        }

        private void txtname_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtname = (TextBox)sender;
            txtname.Text = string.Empty;
            txtname.GotFocus -= txtname_GotFocus;
        }
        static void lineChanger(string newText, string fileName, int line_to_edit)
        {

            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);

        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (warriror_status == 0 && mage_status == 0 && theif_status == 0)
            {
                MessageBox.Show("Please select your class");
            }
            else {

                globalvariables.name = txtname.Text;
                systembackground.newprofile();
                this.NavigationService.Navigate(new Uri("town.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            
            this.NavigationService.Navigate(new Uri("mainmenu.xaml", UriKind.RelativeOrAbsolute));
        }

        private void walk_MediaEnded(object sender, RoutedEventArgs e)
        {
            walk.Position = TimeSpan.FromSeconds(0);
            walk.Play();
        }

        private void mediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            music.Position = TimeSpan.FromSeconds(0);
            music.Play();
        }
    }
}
