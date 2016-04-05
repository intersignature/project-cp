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
    /// Interaction logic for battle.xaml
    /// </summary>
    public partial class battle : Page
    {
        public battle()
        {
            InitializeComponent();
        }
        public static int randomNumber1 { get; set; }
        public static int randomNumber2 { get; set; }
        public static int randomNumber3 { get; set; }

        public static string class_p = "", name_p = "";
        Random random = new Random();
        
        string[] monster = {"skeleton warrior","skeleton mage","skeleton archer","goblin warrior","baby dragon","pirate","king of goblin","fire dragon","captain jack",
        "wraith knight","harpy","prisoner","giant tree","elf","desert snake","mummy","the witch","ghost","Iron golem","orge mage","thief","old king skeleton","whip","chief of thief",
        "cyclop","goblin shaman","blank" };
public void battle1_Loaded(object sender, RoutedEventArgs e)
        {
            music.Play();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(dispatTick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 200);
            timer.Start();
            int randomNumber1 = random.Next(0, 27);
            int randomNumber2 = random.Next(0, 26);
            int randomNumber3 = random.Next(0, 27);
            
        }
        int attacked = 0;
        int num = 0;
        int click = 0;
        int atk = 0;
        int atkcheck = 0;
        private void dispatTick(object sender, EventArgs e)
        {
            if (atkcheck == 0)
            {
                if (num == 0 && click == 0)
                {
                    player1.Source = new BitmapImage(new Uri(@"\char\" + class_p + "battle1.png", UriKind.Relative));
                    monter1.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber1] + "1.png", UriKind.Relative));
                    monter2.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber2] + "1.png", UriKind.Relative));
                    monter3.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber3] + "1.png", UriKind.Relative));
                    num = 2;
                }


                else if (num == 2 && click == 0)
                {
                    player1.Source = new BitmapImage(new Uri(@"\char\" + class_p + "battle3.png", UriKind.Relative));
                    monter1.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber1] + "3.png", UriKind.Relative));
                    monter2.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber2] + "3.png", UriKind.Relative));
                    monter3.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber3] + "3.png", UriKind.Relative));
                    num = 0;
                }
                else if (num == 0 && click == 1)
                {
                    player1.Source = new BitmapImage(new Uri(@"\char\" + class_p + "battle1.png", UriKind.Relative));
                    monter1.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber1] + "1.png", UriKind.Relative));
                    monter2.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber2] + "1.png", UriKind.Relative));
                    monter3.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber3] + "1.png", UriKind.Relative));
                    num = 1;
                }
                else if (num == 1 && click == 1)
                {
                    player1.Source = null;
                    monter1.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber1] + "3.png", UriKind.Relative));
                    monter2.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber2] + "3.png", UriKind.Relative));
                    monter3.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber3] + "3.png", UriKind.Relative));
                    num = 2;
                }
                else if (num == 2 && click == 1)
                {
                    player1.Source = new BitmapImage(new Uri(@"\char\" + class_p + "battle3.png", UriKind.Relative));
                    monter1.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber1] + "1.png", UriKind.Relative));
                    monter2.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber2] + "1.png", UriKind.Relative));
                    monter3.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber3] + "1.png", UriKind.Relative));
                    num = 0;
                }

            }
            else if (atkcheck == 1)
            {
                if (attacked == 1)
                {
                    if (attacked == 1 && num == 0)
                    {
                        monter1.Source = new BitmapImage(new Uri(@"\char\blank1.png", UriKind.Relative));
                        player1.Source = new BitmapImage(new Uri(@"\char\" + class_p + "battle1.png", UriKind.Relative));
                        monter2.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber2] + "1.png", UriKind.Relative));
                        monter3.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber3] + "1.png", UriKind.Relative));
                        num = 1;
                    }
                    else if (attacked == 1 && num == 1)
                    {
                        monter1.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber1] + "3.png", UriKind.Relative));
                        player1.Source = new BitmapImage(new Uri(@"\char\" + class_p + "battle3.png", UriKind.Relative));
                        monter2.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber2] + "3.png", UriKind.Relative));
                        monter3.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber3] + "3.png", UriKind.Relative));
                        num = 2;
                    }
                    else if (attacked == 1 && num == 2)
                    {
                        monter1.Source = new BitmapImage(new Uri(@"\char\blank1.png", UriKind.Relative));
                        player1.Source = new BitmapImage(new Uri(@"\char\" + class_p + "battle1.png", UriKind.Relative));
                        monter2.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber2] + "1.png", UriKind.Relative));
                        monter3.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber3] + "1.png", UriKind.Relative));
                        num = 3;
                    }
                    else if (attacked == 1 && num == 3)
                    {
                        monter1.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber1] + "1.png", UriKind.Relative));
                        player1.Source = new BitmapImage(new Uri(@"\char\" + class_p + "battle3.png", UriKind.Relative));
                        monter2.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber2] + "3.png", UriKind.Relative));
                        monter3.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber3] + "3.png", UriKind.Relative));
                        attacked = 0;
                        num = 0;
                        atkcheck = 0;
                    }
                }
                if (attacked == 2)
                {
                    if (attacked == 2 && num == 0)
                    {
                        monter2.Source = new BitmapImage(new Uri(@"\char\blank1.png", UriKind.Relative));
                        player1.Source = new BitmapImage(new Uri(@"\char\" + class_p + "battle1.png", UriKind.Relative));
                        monter1.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber1] + "1.png", UriKind.Relative));
                        monter3.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber3] + "1.png", UriKind.Relative));
                        num = 1;
                    }
                    else if (attacked == 2 && num == 1)
                    {
                        monter2.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber2] + "3.png", UriKind.Relative));
                        player1.Source = new BitmapImage(new Uri(@"\char\" + class_p + "battle3.png", UriKind.Relative));
                        monter1.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber1] + "3.png", UriKind.Relative));
                        monter3.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber3] + "3.png", UriKind.Relative));
                        num = 2;
                    }
                    else if (attacked == 2 && num == 2)
                    {
                        monter2.Source = new BitmapImage(new Uri(@"\char\blank1.png", UriKind.Relative));
                        player1.Source = new BitmapImage(new Uri(@"\char\" + class_p + "battle1.png", UriKind.Relative));
                        monter1.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber1] + "1.png", UriKind.Relative));
                        monter3.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber3] + "1.png", UriKind.Relative));
                        num = 3;
                    }
                    else if (attacked == 2 && num == 3)
                    {
                        monter2.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber2] + "1.png", UriKind.Relative));
                        player1.Source = new BitmapImage(new Uri(@"\char\" + class_p + "battle3.png", UriKind.Relative));
                        monter1.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber1] + "3.png", UriKind.Relative));
                        monter3.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber3] + "3.png", UriKind.Relative));
                        attacked = 0;
                        num = 0;
                        atkcheck = 0;
                    }
                }
                if (attacked == 3) {
                    if (attacked == 3 && num == 0)
                    {
                        monter3.Source = new BitmapImage(new Uri(@"\char\blank1.png", UriKind.Relative));
                        player1.Source = new BitmapImage(new Uri(@"\char\" + class_p + "battle1.png", UriKind.Relative));
                        monter1.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber1] + "1.png", UriKind.Relative));
                        monter2.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber2] + "1.png", UriKind.Relative));
                        num = 1;
                    }
                    else if (attacked == 3 && num == 1)
                    {
                        monter3.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber3] + "3.png", UriKind.Relative));
                        player1.Source = new BitmapImage(new Uri(@"\char\" + class_p + "battle3.png", UriKind.Relative));
                        monter1.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber1] + "3.png", UriKind.Relative));
                        monter2.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber2] + "3.png", UriKind.Relative));
                        num = 2;
                    }
                    else if (attacked == 3 && num == 2)
                    {
                        monter3.Source = new BitmapImage(new Uri(@"\char\blank1.png", UriKind.Relative));
                        player1.Source = new BitmapImage(new Uri(@"\char\" + class_p + "battle1.png", UriKind.Relative));
                        monter1.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber1] + "1.png", UriKind.Relative));
                        monter2.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber2] + "1.png", UriKind.Relative));
                        num = 3;
                    }
                    else if (attacked == 3 && num == 3)
                    {
                        monter3.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber3] + "1.png", UriKind.Relative));
                        player1.Source = new BitmapImage(new Uri(@"\char\" + class_p + "battle1.png", UriKind.Relative));
                        monter1.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber1] + "3.png", UriKind.Relative));
                        monter2.Source = new BitmapImage(new Uri(@"\char\" + monster[randomNumber2] + "3.png", UriKind.Relative));
                        attacked = 0;
                        num = 0;
                        atkcheck = 0;
                    }
                }
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
            this.NavigationService.Navigate(new Uri("moonshine.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Attack_MouseEnter(object sender, MouseEventArgs e)
        {
            Attack.Foreground = Brushes.Yellow;
        }

        private void Attack_MouseLeave(object sender, MouseEventArgs e)
        {
            Attack.Foreground = Brushes.White;
        }

        private void Skill_MouseEnter(object sender, MouseEventArgs e)
        {
            Skill.Foreground = Brushes.Yellow;
        }

        private void Skill_MouseLeave(object sender, MouseEventArgs e)
        {
            Skill.Foreground = Brushes.White;
        }

        private void Skillulti_MouseEnter(object sender, MouseEventArgs e)
        {
            Skillulti.Foreground = Brushes.Yellow;
        }

        private void Skillulti_MouseLeave(object sender, MouseEventArgs e)
        {
            Skillulti.Foreground = Brushes.White;
        }

        private void Item_MouseEnter(object sender, MouseEventArgs e)
        {
            Item.Foreground = Brushes.Yellow;
        }

        private void Item_MouseLeave(object sender, MouseEventArgs e)
        {
            Item.Foreground = Brushes.White;
        }

        private void player1_MouseEnter(object sender, MouseEventArgs e)
        {
            display.Content = name_p;
        }

        private void player1_MouseLeave(object sender, MouseEventArgs e)
        {
           if (click != 1)
            {
                display.Content = "";
            }
        }

        private void monter1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (monster[randomNumber1] != "blank")
            {
                display.Content = monster[randomNumber1];
            }
        }

        private void monter1_MouseLeave(object sender, MouseEventArgs e)
        {
            display.Content = "";
        }

        private void monter3_MouseEnter(object sender, MouseEventArgs e)
        {
            if (monster[randomNumber3] != "blank")
            {
                display.Content = monster[randomNumber3];
            }
        }

        private void monter3_MouseLeave(object sender, MouseEventArgs e)
        {
            display.Content = "";
        }

        private void monter2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (monster[randomNumber2] != "blank")
            {
                display.Content = monster[randomNumber2];
            }
        }

        private void player1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            click = 1;
            display.Content = name_p;
            action.Content = "คุนจะทำไรครับ โจมตี ใช้ สกิล ใช้ไอเทม";
        }

        private void Attack_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            atk = 1;
            if (click == 1)
            {
                action.Content = "คุนเลือกที่จะโจมตีโจมตีตัวไหนล่ะ";
            }
        }

        private void monter1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (atk == 1 && click == 1)
            {
                action.Content = "คุณพึ่งได้ทำการโจมตี " + monster[randomNumber1];
                atk = 0;
                click = 0;
                num = 0;
                attacked = 1;
                smash.Stop();
                smash.Play();
                atkcheck = 1;

            }
        }

        private void monter3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (atk == 1 && click == 1)
            {
                action.Content = "คุณพึ่งได้ทำการโจมตี " + monster[randomNumber3];
                atk = 0;
                click = 0;
                num = 0;
                smash.Stop();
                smash.Play();
                attacked = 3;
                atkcheck = 1;
            }
        }

        private void monter2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (atk == 1 && click == 1)
            {
                action.Content = "คุณพึ่งได้ทำการโจมตี " + monster[randomNumber2];
                atk = 0;
                click = 0;
                num = 0;
                smash.Stop();
                smash.Play();
                attacked = 2;
                atkcheck = 1;
            }
        }

        private void music_MediaEnded(object sender, RoutedEventArgs e)
        {
            music.Position = TimeSpan.FromSeconds(0);
            music.Play();
        }

        private void monter2_MouseLeave(object sender, MouseEventArgs e)
        {
            display.Content = "";
        }
    }
}
