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

namespace projectcompro.res
{
    /// <summary>
    /// Interaction logic for blacksmith.xaml
    /// </summary>
    public partial class blacksmith : Page
    {
        string[] item = { "Bone Knight", "Durandul", "Dratt Sword", "Barrier", "Tortoiseshell", "Goddess Give", "Heaven Sword", "Trinity Sword", "Gravity", "Taruntura leg",
            "Priest Savage", "Lumai Two-handed sword", "Arcana staff", "Aston staff", "Warlock staff", "Candle staff", "Saline", "Greer Lostines rank", "Codex", "Bible",
            "Galdrabok", "Honorius", "Abramelin", "Voodo",  "Fairy bow","Excel bow","Heart seeker","Iron bow","Luna bow","LoloPhanter", "Rama dagger","Soul dagger","Dragon dagger","Overblade","Death weaver tooth","Wedge poison"};
        string keepitem1 = "", keepitem2 = "", keepitem3 = "";
        int check = 0, buy_check = 0;
        public static int randomNumber1 { get; set; }
        public static int randomNumber2 { get; set; }
        public static int randomNumber3 { get; set; }
        public string buy_item = "";

        public blacksmith()
        {
            InitializeComponent();
        }
        public static void dispatTick(object sender, EventArgs e)
        {

            Random random = new Random();
            blacksmith.randomNumber1 = random.Next(0, 36);
            blacksmith.randomNumber2 = random.Next(0, 36);
            while (blacksmith.randomNumber1 == blacksmith.randomNumber2)
            {
                blacksmith.randomNumber2 = random.Next(0, 36);

            }
            blacksmith.randomNumber3 = random.Next(0, 36);
            while (blacksmith.randomNumber3 == blacksmith.randomNumber2 || blacksmith.randomNumber3 == blacksmith.randomNumber1)
            {
                blacksmith.randomNumber3 = random.Next(0, 36);
            }


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
            
            MainWindow.item_inven = buyweapon;
            for (int j = 0; j < numbuy; j++)
            {
                for (int i = 0; i < 30; i++)
                {
                    if (MainWindow.slot[i] == "item")
                    {
                        MainWindow.slot[i] = MainWindow.item_inven[j];
                        break;
                    }
                }
            }
            this.NavigationService.Navigate(new Uri("town.xaml", UriKind.RelativeOrAbsolute));
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

        private void sell_MouseEnter(object sender, MouseEventArgs e)
        {
            if (check == 0)
            {
                jick.Stop();
                jick.Play();
                sell.Foreground = Brushes.Yellow;
            }
        }

        private void sell_MouseLeave(object sender, MouseEventArgs e)
        {
            sell.Foreground = Brushes.White;
        }

        private void upgrade_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            upgrade.Foreground = Brushes.Yellow;
        }


        private void buy_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            keepitem1 = item[randomNumber1];
            keepitem2 = item[randomNumber2];
            keepitem3 = item[randomNumber3];
            item1.Content = item[randomNumber1];
            item2.Content = item[randomNumber2];
            item3.Content = item[randomNumber3];
            buyitem.Content = "BUY";
            buy_check += 1;
            check += 1;
            if (check == 1)
            {
                buy.Content = "BACK";
                sell.Content = "";
                upgrade.Content = "";
            }
            else if (check == 2)
            {
                buy.Content = " BUY";
                sell.Content = "SELL";
                upgrade.Content = "UPGRADE";
                buy_check = 0;
                check = 0;
                item1.Content = "";
                item2.Content = "";
                item3.Content = "";
                buyitem.Content = "";
                
                MainWindow.item_inven = buyweapon;
                for (int j = 0; j < numbuy; j++)
                {
                    for (int i = 0; i < 30; i++)
                    {
                        if (MainWindow.slot[i] == "item")
                        {
                            MainWindow.slot[i] = MainWindow.item_inven[j];
                            break;
                        }
                    }
                }

            }
        }
        
        private void sell_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            check += 1;
            if (check == 1)
            {
                inventory.sell = 1;
                this.NavigationService.Navigate(new Uri("inventory.xaml", UriKind.RelativeOrAbsolute));
            }
            else if (check == 2)
            {
                buy.Content = " BUY";
                sell.Content = "SELL";
                upgrade.Content = "UPGRADE";
                check = 0;
            }
        }

        private void upgrade_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            check += 1;
            if (check == 1)
            {
                buy.Content = "BACK";
                sell.Content = "";
                upgrade.Content = "";
            }
            else if (check == 2)
            {
                buy.Content = " BUY";
                sell.Content = "SELL";
                upgrade.Content = "UPGRADE";
                check = 0;
            }
        }

        private void upgrade_MouseLeave(object sender, MouseEventArgs e)
        {
            if (check == 0)
            {
                jick.Stop();
                jick.Play();
                upgrade.Foreground = Brushes.White;
            }
        }

        private void blacksmith1_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void item1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (buy_check == 1)
            {
                item1.Foreground = Brushes.Yellow;
                itemshow.Source = new BitmapImage(new Uri(@"\weapon\" + keepitem1 + ".png", UriKind.Relative));
            }
        }

        private void item1_MouseLeave(object sender, MouseEventArgs e)
        {
            if (buy_check == 1)
            {
                item1.Foreground = Brushes.White;
                itemshow.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
            }
        }

        private void item2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (buy_check == 1)
            {
                item2.Foreground = Brushes.Yellow;
                itemshow.Source = new BitmapImage(new Uri(@"\weapon\" + keepitem2 + ".png", UriKind.Relative));
            }
        }

        private void buyitem_MouseEnter(object sender, MouseEventArgs e)
        {
            buyitem.Foreground = Brushes.Yellow;
        }

        private void buyitem_MouseLeave(object sender, MouseEventArgs e)
        {
            buyitem.Foreground = Brushes.Black;
        }

        private void buyitem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (check == 1)
            {
                MessageBox.Show(buy_item);
            }
           
            
            if (MainWindow.numslot >= 30)
            {
                MessageBox.Show("คุณครับ ของคุณเต็มแล้วครับ");
                MainWindow.numslot = 30;
            }
            else
            {
                buyweapon[numbuy] = chooseitem;
                numbuy += 1;
                MainWindow.numslot += 1;
            }
            
        }
        string chooseitem { get; set; }
        int numbuy = 0;
        string[] buyweapon = new string[30];
        private void item1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(buy_check  == 1)
            {
                buy_item = keepitem1;
            }
            chooseitem = keepitem1;
        }

        private void item3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (buy_check == 1)
            {
                buy_item = keepitem3;
            }
            chooseitem = keepitem3;
        }

        private void item2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (buy_check == 1)
            {
                buy_item = keepitem2;
            }
            chooseitem = keepitem2;
        }

        private void item2_MouseLeave(object sender, MouseEventArgs e)
        {
            if (buy_check == 1)
            {
                item2.Foreground = Brushes.White;
                itemshow.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
            }
        }

        private void item3_MouseEnter(object sender, MouseEventArgs e)
        {
            if (buy_check == 1)
            {
                item3.Foreground = Brushes.Yellow;
                itemshow.Source = new BitmapImage(new Uri(@"\weapon\" + keepitem3 + ".png", UriKind.Relative));
            }
        }

        private void item3_MouseLeave(object sender, MouseEventArgs e)
        {
            if (buy_check == 1)
            {
                item3.Foreground = Brushes.White;
                itemshow.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
            }
        }
    }
}
