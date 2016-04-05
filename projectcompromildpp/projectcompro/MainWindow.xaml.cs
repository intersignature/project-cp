using projectcompro.res;
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
using System.Diagnostics;
using System.IO;

namespace projectcompro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class globalvariables
    {
        public static string[] outputvar = new string[15]; // output var to c
        public static string[] sentvar = new string[15]; // send var to c
        public static int var, var2, loop, loopout;
        // ตัวเลือก เเละ การส่งค่าในc บนนะ
        public static int[] hp = new int[5];//full hp 
        public static int[,] monster = new int[5, 6];//type hp mp atk def luck
        public static int[,,] monsterdebug = new int[5, 10, 4]; // stats +- dmg turn
        public static int[,] hero = new int[5, 7];//class hp mp atk def luck use
        public static int[,,] herodebug = new int[5, 10, 4]; // stats +- dmg turn
        public static int[,] cdhero = new int[5, 16];//cd   
        public static int[] stun = new int[10];
        public static int[] dropstat = new int[7]; // exp 5 ตัว money จำนวน drop
        // battle Zone
        public static string name;
        public static int M = 0, money = 0, lvmap = 1, lvstage = 1;
        public static int[,] stats = new int[5, 11]; //lv exp class hp mp atk def luck weapon amror statsdead
        public static int[] etcitem = new int[12]; // hp 1-4 mp 1-4 bth defbreak1-3
        public static int[,] skill = new int[5, 16];//1111222222333444
        public static string[] nameitem = new string[30];
        public static int[,] itemstats = new int[30, 12];//hp mp atk def luck momey rank ehc type(ขออาวูธ) nameitem(รหัสชื่ออาวูธ) point(weapon0,armor1) use
    }
    public class systembackground
    {
        public static string dir = Environment.CurrentDirectory;
        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);

        }
        public static void loadprofile()
        {

        }
        public static void saveprofile()
        {
            int i;
            lineChanger("1", dir + "\\data.txt", 1);
            lineChanger(globalvariables.M.ToString() + " " + globalvariables.money.ToString()
                + " " + globalvariables.lvmap.ToString() + " " + globalvariables.lvstage.ToString(), dir + "\\data.txt", 2);
            lineChanger(globalvariables.name, dir + "\\data.txt", 3);
            for (i = 4; i < 9; ++i)
            {
                lineChanger(globalvariables.stats[i - 4, 0].ToString() + " " +
                    globalvariables.stats[i - 4, 1].ToString() + " " +
                    globalvariables.stats[i - 4, 2].ToString() + " " +
                    globalvariables.stats[i - 4, 3].ToString() + " " +
                    globalvariables.stats[i - 4, 4].ToString() + " " +
                    globalvariables.stats[i - 4, 5].ToString() + " " +
                    globalvariables.stats[i - 4, 6].ToString() + " " +
                    globalvariables.stats[i - 4, 7].ToString() + " " +
                    globalvariables.stats[i - 4, 8].ToString() + " " +
                    globalvariables.stats[i - 4, 9].ToString() + " " +
                    globalvariables.stats[i - 4, 10].ToString() + " ", dir + "\\data.txt", i);
            }
            lineChanger(globalvariables.etcitem[0].ToString() + " " +
                    globalvariables.etcitem[1].ToString() + " " +
                    globalvariables.etcitem[2].ToString() + " " +
                    globalvariables.etcitem[3].ToString() + " " +
                    globalvariables.etcitem[4].ToString() + " " +
                    globalvariables.etcitem[5].ToString() + " " +
                    globalvariables.etcitem[6].ToString() + " " +
                    globalvariables.etcitem[7].ToString() + " " +
                    globalvariables.etcitem[8].ToString() + " " +
                    globalvariables.etcitem[9].ToString() + " " +
                    globalvariables.etcitem[10].ToString() + " " +
                    globalvariables.etcitem[11].ToString() + " "
                    , dir + "\\data.txt", 9);
            for (i = 10; i < 15; ++i)
            {
                lineChanger(globalvariables.skill[i - 10, 0].ToString() + " " +
                    globalvariables.skill[i - 10, 1].ToString() + " " +
                    globalvariables.skill[i - 10, 2].ToString() + " " +
                    globalvariables.skill[i - 10, 3].ToString() + " " +
                    globalvariables.skill[i - 10, 4].ToString() + " " +
                    globalvariables.skill[i - 10, 5].ToString() + " " +
                    globalvariables.skill[i - 10, 6].ToString() + " " +
                    globalvariables.skill[i - 10, 7].ToString() + " " +
                    globalvariables.skill[i - 10, 8].ToString() + " " +
                    globalvariables.skill[i - 10, 9].ToString() + " " +
                    globalvariables.skill[i - 10, 10].ToString() + " " +
                    globalvariables.skill[i - 10, 11].ToString() + " " +
                    globalvariables.skill[i - 10, 12].ToString() + " " +
                    globalvariables.skill[i - 10, 13].ToString() + " " +
                    globalvariables.skill[i - 10, 14].ToString() + " " +
                    globalvariables.skill[i - 10, 15].ToString() + " ", dir + "\\data.txt", i);
            }
            lineChanger(globalvariables.nameitem[0].ToString() + " " +
                globalvariables.nameitem[1].ToString() + " " +
                globalvariables.nameitem[2].ToString() + " " +
                globalvariables.nameitem[3].ToString() + " " +
                globalvariables.nameitem[4].ToString() + " ", dir + "\\data.txt", 15);
            lineChanger(globalvariables.nameitem[5].ToString() + " " +
                    globalvariables.nameitem[6].ToString() + " " +
                    globalvariables.nameitem[7].ToString() + " " +
                    globalvariables.nameitem[8].ToString() + " " +
                    globalvariables.nameitem[9].ToString() + " ", dir + "\\data.txt", 16);
            lineChanger(globalvariables.nameitem[10].ToString() + " " +
                    globalvariables.nameitem[11].ToString() + " " +
                    globalvariables.nameitem[12].ToString() + " " +
                    globalvariables.nameitem[13].ToString() + " " +
                    globalvariables.nameitem[14].ToString() + " ", dir + "\\data.txt", 17);
            lineChanger(globalvariables.nameitem[15].ToString() + " " +
                    globalvariables.nameitem[16].ToString() + " " +
                    globalvariables.nameitem[17].ToString() + " " +
                    globalvariables.nameitem[18].ToString() + " " +
                    globalvariables.nameitem[19].ToString() + " ", dir + "\\data.txt", 18);
            lineChanger(globalvariables.nameitem[20].ToString() + " " +
                    globalvariables.nameitem[21].ToString() + " " +
                    globalvariables.nameitem[22].ToString() + " " +
                    globalvariables.nameitem[23].ToString() + " " +
                    globalvariables.nameitem[24].ToString() + " ", dir + "\\data.txt", 19);
            lineChanger(globalvariables.nameitem[25].ToString() + " " +
                    globalvariables.nameitem[26].ToString() + " " +
                    globalvariables.nameitem[27].ToString() + " " +
                    globalvariables.nameitem[28].ToString() + " " +
                    globalvariables.nameitem[29].ToString() + " ", dir + "\\data.txt", 20);
            for (i = 21; i < 51; ++i)
            {
                lineChanger(globalvariables.itemstats[i - 21, 0].ToString() + " " +
                        globalvariables.itemstats[i - 21, 1].ToString() + " " +
                        globalvariables.itemstats[i - 21, 2].ToString() + " " +
                        globalvariables.itemstats[i - 21, 3].ToString() + " " +
                        globalvariables.itemstats[i - 21, 4].ToString() + " " +
                        globalvariables.itemstats[i - 21, 5].ToString() + " " +
                        globalvariables.itemstats[i - 21, 6].ToString() + " " +
                        globalvariables.itemstats[i - 21, 7].ToString() + " " +
                        globalvariables.itemstats[i - 21, 8].ToString() + " " +
                        globalvariables.itemstats[i - 21, 9].ToString() + " " +
                        globalvariables.itemstats[i - 21, 10].ToString() + " " +
                        globalvariables.itemstats[i - 21, 11].ToString() + " " +
                        globalvariables.itemstats[i - 21, 12].ToString() + " "
                        , dir + "\\data.txt", i);
            }
        }
        public static void newprofile()
        {
            int i;
            globalvariables.sentvar[0] = 2.ToString(); //select
            globalvariables.sentvar[1] = 1.ToString(); //lv
            globalvariables.loop = 3; // loop input to cmd
            globalvariables.loopout = 1; // loop output for cmd
            systempowerc.systemrun();// herogen
            // ------------------------output----------------------
            globalvariables.stats[0, 0] = 1;
            globalvariables.stats[0, 10] = 1;
            string[] list = globalvariables.outputvar[0].Split(' ');
            for (i = 0; i < 6; ++i)
            {
                globalvariables.stats[0, i + 2] = int.Parse(list[i]);
            }
            // ----------------------------------------------------
            globalvariables.sentvar[0] = 3.ToString(); //select
            globalvariables.sentvar[1] = globalvariables.sentvar[2]; //type classselect or clickselect
            globalvariables.sentvar[2] = 0.ToString(); //name
            globalvariables.sentvar[3] = 0.ToString(); //rank 
            globalvariables.loop = 4; // loop input to cmd
            globalvariables.loopout = 1; // loop output for cmd
            systempowerc.systemrun();
            // ----------------------------------------------------
            globalvariables.itemstats[0, 11] = 1;
            globalvariables.itemstats[0, 10] = 0;
            globalvariables.itemstats[0, 8] = int.Parse(globalvariables.sentvar[1]);
            string[] list1 = globalvariables.outputvar[0].Split(' ');
            for (i = 0; i < 5; ++i)
            {
                globalvariables.itemstats[0, i + 2] = int.Parse(list1[i]);
            }
            // ---------------------------------------------------
            globalvariables.sentvar[0] = 4.ToString(); //select
            globalvariables.sentvar[1] = 0.ToString(); //name 
            globalvariables.sentvar[2] = 0.ToString(); //rank
            globalvariables.loop = 3; // loop input to cmd
            globalvariables.loopout = 1; // loop output for cmd
            systempowerc.systemrun();
            // ---------------------------------------------------
            globalvariables.itemstats[1, 11] = 1;
            globalvariables.itemstats[1, 10] = 1;
            string[] list2 = globalvariables.outputvar[0].Split(' ');
            globalvariables.itemstats[1, 0] = int.Parse(list2[0]);
            globalvariables.itemstats[1, 1] = int.Parse(list2[1]);
            globalvariables.itemstats[1, 3] = int.Parse(list2[2]);
            globalvariables.itemstats[1, 5] = int.Parse(list2[3]);
            globalvariables.itemstats[1, 6] = int.Parse(list2[4]);
            // ----------------------------------------------------
        }
        public static void itenswitch(int sw, int ch, int tag)//ch=ตัวละคร sw=อาวุธหรือเกราะ tag=อาวูธชิ้นใหม่
        {
            int tamp = globalvariables.stats[ch, sw + 8];
            if (globalvariables.itemstats[tag, 11] == 0)
            {
                globalvariables.stats[ch, sw + 8] = tag;
                globalvariables.itemstats[tag, 11] = 1;
                globalvariables.itemstats[tamp, 11] = 0;
            }
            else
            {
                MessageBox.Show("Cant use More Than One Hero");
            }
        }
    }
    public class systempowerc
    {

        public static void systemrun()
        {
            string dir = Environment.CurrentDirectory;
            ProcessStartInfo info = new ProcessStartInfo();
            Process process = new Process();
            int i = 0;
            info.FileName = dir + "\\12345.exe";
            info.UseShellExecute = false;
            info.RedirectStandardOutput = true;
            info.RedirectStandardInput = true;
            info.CreateNoWindow = false;
            process.StartInfo = info;
            process.Start();
            for (i = 0; i < globalvariables.loop; ++i)
            {
                process.StandardInput.WriteLine(globalvariables.sentvar[i]);
            }
            for (i = 0; i < globalvariables.loopout; ++i)
            {
                globalvariables.outputvar[i] = process.StandardOutput.ReadLine();
            }
            process.WaitForExit();
        }
        public static void battlesystem()
        {
            ProcessStartInfo info = new ProcessStartInfo();
            Process process = new Process();
            int i = 0;
            info.FileName = "Untitled1.exe";
            info.UseShellExecute = false;
            info.RedirectStandardOutput = true;
            info.RedirectStandardInput = true;
            info.CreateNoWindow = true;
            process.StartInfo = info;
            process.Start();
            for (i = 0; i < 12; ++i) // 0 - 11 
            {
                process.StandardInput.WriteLine(globalvariables.sentvar[i]);
            }
            for (i = 0; i < globalvariables.loopout; ++i)
            {
                globalvariables.outputvar[i] = process.StandardOutput.ReadLine();
            }
            process.WaitForExit();
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mediaElement_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        public static int numslot = 0;
        public static string[] item_inven = { };
        public static string[] slot = {"item", "item", "item", "item", "item", "item", "item", "item", "item", "item",
        "item","item","item","item","item","item","item","item","item","item",
        "item","item","item","item","item","item","item","item","item","item",};
        public void frame_Loaded(object sender, RoutedEventArgs e)
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
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(blacksmith.dispatTick);
            timer.Interval = new TimeSpan(0, 0, 10);
            timer.Start();
           
        }
    }
}
