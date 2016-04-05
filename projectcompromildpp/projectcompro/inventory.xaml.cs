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
    /// Interaction logic for inventory.xaml
    /// </summary>
    public partial class inventory : Page
    {
        public inventory()
        {
            InitializeComponent();
        }
        public static int sell = 0;
        private void back_MouseEnter(object sender, MouseEventArgs e)
        {
            jick.Stop();
            jick.Play();
            back.Foreground = Brushes.Yellow;
        }

        private void back_MouseLeave(object sender, MouseEventArgs e)
        {
            back.Foreground = Brushes.Black;
        }

        private void inventory1_Loaded(object sender, RoutedEventArgs e)
        {
            music.Play();
            if(sell == 1)
            {
                sellshow.Source = new BitmapImage(new Uri(@"/res/walet.png", UriKind.Relative));

            }
        }
        string[] temp = new string[30];
        int numsell = 0;
     
        private void back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
            
        {
            if (sell == 1)
            {
                    this.NavigationService.Navigate(new Uri("blacksmith.xaml", UriKind.RelativeOrAbsolute));
                
               
            }
            else if(sell == 0)
            {
                this.NavigationService.Navigate(new Uri("status.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < 30; i++)
            {
                if(i==0)
                {
                    item1.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if(i == 1)
                {
                    item2.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 2)
                {
                    item3.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 3)
                {
                    item4.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 4)
                {
                    item5.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 5)
                {
                    item6.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 6)
                {
                    item7.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 7)
                {
                    item8.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 8)
                {
                    item9.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 9)
                {
                    item10.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 10)
                {
                    item11.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 11)
                {
                    item12.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 12)
                {
                    item13.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 13)
                {
                    item14.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 14)
                {
                    item15.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 15)
                {
                    item16.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 16)
                {
                    item17.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 17)
                {
                    item18.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 18)
                {
                    item19.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 19)
                {
                    item20.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 20)
                {
                    item21.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 21)
                {
                    item22.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 22)
                {
                    item23.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 23)
                {
                    item24.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 24)
                {
                    item25.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 25)
                {
                    item26.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 26)
                {
                    item27.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 27)
                {
                    item28.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 28)
                {
                    item29.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
                else if (i == 29)
                {
                    item30.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[i] + ".png", UriKind.Relative));
                }
            }
        }
        int wantsell = 0;
       
        int forsure = 0;
        int[] suresell = new int[30];
        private void item1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if(wantsell == 1)
                {
                    item1.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 0;
                    forsure += 1;
                }
            }
        }

        private void item2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item2.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 1;
                    forsure += 1;
                }
            }
        }

        private void item3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item3.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 2;
                    forsure += 1;
                }
            }
        }

        private void item4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item4.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 3;
                    forsure += 1;
                }
            }
        }

        private void item5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item5.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 4;
                    forsure += 1;
                }
            }
        }

        private void item6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item6.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 5;
                    forsure += 1;
                }
            }
        }

        private void item7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item7.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 6;
                    forsure += 1;
                }
            }
        }

        private void item8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item8.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 7;
                    forsure += 1;
                }
            }
        }

        private void item9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item9.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 8;
                    forsure += 1;
                }
            }
        }

        private void item10_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item10.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 9;
                    forsure += 1;
                }
            }
        }

        private void item11_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item11.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 10;
                    forsure += 1;
                }
            }
        }

        private void item12_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item12.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 11;
                    forsure += 1;
                }
            }
        }

        private void item13_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item13.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 12;
                    forsure += 1;
                }
            }
        }

        private void item14_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item14.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 13;
                    forsure += 1;
                }
            }
        }

        private void item15_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item15.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 14;
                    forsure += 1;
                }
            }
        }

        private void item16_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item16.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 15;
                    forsure += 1;
                }
            }
        }

        private void item17_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item17.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 16;
                    forsure += 1;
                }
            }
        }

        private void item18_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item18.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 17;
                    forsure += 1;
                }
            }
        }

        private void item19_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item19.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 18;
                    forsure += 1;
                }
            }
        }

        private void item20_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item20.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 19;
                    forsure += 1;
                }
            }
        }

        private void item21_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item21.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 20;
                    forsure += 1;
                }
            }
        }

        private void item22_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item22.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 21;
                    forsure += 1;
                }
            }
        }

        private void item23_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item23.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 22;
                    forsure += 1;
                }
            }
        }

        private void item24_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item24.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 23;
                    forsure += 1;
                }
            }
        }

        private void item25_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item25.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 24;
                    forsure += 1;
                }
            }
        }

        private void item26_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item26.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 25;
                    forsure += 1;
                }
            }
        }

        private void item27_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item27.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 26;
                    forsure += 1;
                }
            }
        }

        private void item28_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item28.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 27;
                    forsure += 1;
                }
            }
        }

        private void item29_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item29.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 28;
                    forsure += 1;
                }
            }
        }

        private void item30_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    item30.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    suresell[forsure] = 29;
                    forsure += 1;
                }
            }
        }

    

        

        private void image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                ok.Source = new BitmapImage(new Uri(@"\res\suresell.png", UriKind.Relative));
                cancel.Source = new BitmapImage(new Uri(@"\res\no.png", UriKind.Relative));
                back.Content = null;
                wantsell = 1;
            }
        }

      

        

        private void cancel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    back.Content = "Back";
                    cancel.Source = null;
                    ok.Source = null;
                    wantsell = 0;
                    
                    item1.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[0] + ".png", UriKind.Relative));
                    item2.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[1] + ".png", UriKind.Relative));
                    item3.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[2] + ".png", UriKind.Relative));
                    item4.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[3] + ".png", UriKind.Relative));
                    item5.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[4] + ".png", UriKind.Relative));
                    item6.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[5] + ".png", UriKind.Relative));
                    item7.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[6] + ".png", UriKind.Relative));
                    item8.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[7] + ".png", UriKind.Relative));
                    item9.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[8] + ".png", UriKind.Relative));
                    item10.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[9] + ".png", UriKind.Relative));
                    item11.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[10] + ".png", UriKind.Relative));
                    item12.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[11] + ".png", UriKind.Relative));
                    item13.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[12] + ".png", UriKind.Relative));
                    item14.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[13] + ".png", UriKind.Relative));
                    item15.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[14] + ".png", UriKind.Relative));
                    item16.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[15] + ".png", UriKind.Relative));
                    item17.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[16] + ".png", UriKind.Relative));
                    item18.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[17] + ".png", UriKind.Relative));
                    item19.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[18] + ".png", UriKind.Relative));
                    item20.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[19] + ".png", UriKind.Relative));
                    item21.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[20] + ".png", UriKind.Relative));
                    item22.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[21] + ".png", UriKind.Relative));
                    item23.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[22] + ".png", UriKind.Relative));
                    item24.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[23] + ".png", UriKind.Relative));
                    item25.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[24] + ".png", UriKind.Relative));
                    item26.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[25] + ".png", UriKind.Relative));
                    item27.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[26] + ".png", UriKind.Relative));
                    item28.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[27] + ".png", UriKind.Relative));
                    item29.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[28] + ".png", UriKind.Relative));
                    item30.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[29] + ".png", UriKind.Relative));
                    forsure = 0;
                    suresell = new int[30];
                }
            }
        }

        private void ok_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    for (int i = 0; i < forsure; i++)
                    {
                        MainWindow.slot[suresell[i]] = "item";

                    }
                    back.Content = "Back";
                    cancel.Source = null;
                    ok.Source = null;
                    wantsell = 0;
                    MainWindow.numslot -= forsure;
                   
                    for (int i = 0; i < 30; i++)
                    {
                        if (MainWindow.slot[i] != "item")
                        {
                            temp[numsell] = MainWindow.slot[i];
                            numsell += 1;
                        }
                        MainWindow.slot[i] = "item";
                    }
                    for (int i = 0; i < numsell; i++)
                    {
                        MainWindow.slot[i] = temp[i];
                    }
                    item1.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item2.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item3.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item4.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item5.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item6.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item7.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item8.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item9.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item10.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item11.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item12.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item13.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item14.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item15.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item16.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item17.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item18.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item19.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item20.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item21.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item22.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item23.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item24.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item25.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item26.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item27.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item28.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item29.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item30.Source = new BitmapImage(new Uri(@"\res\blank.png", UriKind.Relative));
                    item1.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[0] + ".png", UriKind.Relative));
                    item2.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[1] + ".png", UriKind.Relative));
                    item3.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[2] + ".png", UriKind.Relative));
                    item4.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[3] + ".png", UriKind.Relative));
                    item5.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[4] + ".png", UriKind.Relative));
                    item6.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[5] + ".png", UriKind.Relative));
                    item7.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[6] + ".png", UriKind.Relative));
                    item8.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[7] + ".png", UriKind.Relative));
                    item9.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[8] + ".png", UriKind.Relative));
                    item10.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[9] + ".png", UriKind.Relative));
                    item11.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[10] + ".png", UriKind.Relative));
                    item12.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[11] + ".png", UriKind.Relative));
                    item13.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[12] + ".png", UriKind.Relative));
                    item14.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[13] + ".png", UriKind.Relative));
                    item15.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[14] + ".png", UriKind.Relative));
                    item16.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[15] + ".png", UriKind.Relative));
                    item17.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[16] + ".png", UriKind.Relative));
                    item18.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[17] + ".png", UriKind.Relative));
                    item19.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[18] + ".png", UriKind.Relative));
                    item20.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[19] + ".png", UriKind.Relative));
                    item21.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[20] + ".png", UriKind.Relative));
                    item22.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[21] + ".png", UriKind.Relative));
                    item23.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[22] + ".png", UriKind.Relative));
                    item24.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[23] + ".png", UriKind.Relative));
                    item25.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[24] + ".png", UriKind.Relative));
                    item26.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[25] + ".png", UriKind.Relative));
                    item27.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[26] + ".png", UriKind.Relative));
                    item28.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[27] + ".png", UriKind.Relative));
                    item29.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[28] + ".png", UriKind.Relative));
                    item30.Source = new BitmapImage(new Uri(@"\weapon\" + MainWindow.slot[29] + ".png", UriKind.Relative));
                    numsell = 0;
                    temp = new string[30];
                    forsure = 0;
                    suresell = new int[30];
                    
             
                }
            }
        }

        private void sellshow_MouseEnter(object sender, MouseEventArgs e)
        {
            if(sell == 1)
            {
                sellshow.Source = new BitmapImage(new Uri(@"\res\walet click.png", UriKind.Relative));
            }
        }

        private void sellshow_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sell == 1)
            {
                sellshow.Source = new BitmapImage(new Uri(@"\res\walet.png", UriKind.Relative));
            }
        }

        private void ok_MouseEnter(object sender, MouseEventArgs e)
        {
            if(sell == 1)
            {
                if (wantsell == 1){
                    {
                        ok.Source = new BitmapImage(new Uri(@"\res\suresellclick.png", UriKind.Relative));
                    }
                }
            }
        }

        private void ok_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    {
                        ok.Source = new BitmapImage(new Uri(@"\res\suresell.png", UriKind.Relative));
                    }
                }
            }
        }

        private void cancel_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    {
                        cancel.Source = new BitmapImage(new Uri(@"\res\noclick.png", UriKind.Relative));
                    }
                }
            }
        }

        private void cancel_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sell == 1)
            {
                if (wantsell == 1)
                {
                    {
                        cancel.Source = new BitmapImage(new Uri(@"\res\no.png", UriKind.Relative));
                    }
                }
            }
        }
    }
}
