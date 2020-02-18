/*
 * Purpose: Crossmodal Matching Interface for NHanCE Research Lab, Purdue Univeristy
 * 
 * Creator: Collin Hong-da Li | li2718@purdue.edu
 * 
 * 
 * 
 */
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;
using System.IO;
using System.Media;
using System.Threading;

namespace Crossmodal_Interface
{
    //class for specific user intensities*

    public partial class Form1 : Form
    {
        private string name;
        private int auditoryValue;
        private int tactileValue;
        private int [] tactileValues = new int[3];
        private int [] audioValues = new int[3];
        private string data;

        [DllImport(@"C:\Users\minisim\Desktop\Tactors\TDKAPI_1.0.6.0\libraries\Windows\TactorInterface.dll")]
        public static extern IntPtr GetVersionNumber();

        [DllImport(@"C:\Users\minisim\Desktop\Tactors\TDKAPI_1.0.6.0\libraries\Windows\TactorInterface.dll",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int Discover(int type);

        [DllImport(@"C:\Users\minisim\Desktop\Tactors\TDKAPI_1.0.6.0\libraries\Windows\TactorInterface.dll",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int Connect(string name, int type, IntPtr _callback);

        [DllImport(@"C:\Users\minisim\Desktop\Tactors\TDKAPI_1.0.6.0\libraries\Windows\TactorInterface.dll",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int InitializeTI();

        [DllImport(@"C:\Users\minisim\Desktop\Tactors\TDKAPI_1.0.6.0\libraries\Windows\TactorInterface.dll",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int Pulse(int deviceID, int tacNum, int msDuration, int delay);

        [DllImport(@"C:\Users\minisim\Desktop\Tactors\TDKAPI_1.0.6.0\libraries\Windows\TactorInterface.dll",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetDiscoveredDeviceName(int index);

        [DllImport(@"C:\Users\minisim\Desktop\Tactors\TDKAPI_1.0.6.0\libraries\Windows\TactorInterface.dll",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int DiscoverLimited(int type, int amount);

        [DllImport(@"C:\Users\minisim\Desktop\Tactors\TDKAPI_1.0.6.0\libraries\Windows\TactorInterface.dll",
           CallingConvention = CallingConvention.Cdecl)]
        public static extern int ChangeGain(int deviceID, int tacNum, int gainval, int delay);

        [DllImport(@"C:\Users\minisim\Desktop\Tactors\TDKAPI_1.0.6.0\libraries\Windows\TactorInterface.dll",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int CloseAll();

        private int tactorOn;

        private SoundPlayer minSound;
        private SoundPlayer lowSound;
        private SoundPlayer highSound;
        private SoundPlayer maxSound;
        public Form1()
        {
            this.Location = new Point(1280, 24);
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            InitializeTI();
            tactorOn = Discover(1);
            string name = Marshal.PtrToStringAnsi((IntPtr)GetDiscoveredDeviceName(0));
            Connect(name, 1, IntPtr.Zero);



            welcomeText.Text = "Welcome to the NHanCE Laboratories Crossmodal Matching Interface\n Enter your full name and press \"Enter\"";
            if (tactorOn == 0)
            {
                welcomeText.Text = "Tactor not connected!\nPlease connect the tactor and press retry";
                retry.Visible = true;
                nameInput.Visible = false;
                nameLabel.Visible = false;
           
            }
            welcomeText.Font = new Font("Arial", 20, FontStyle.Bold);
            results.Text = "";
            results.Font = new Font("Arial", 20, FontStyle.Bold);
            nameLabel.Location = new Point(540,255);
            nameInput.Location = new Point(600,250);
            results.Location = new Point(0, 0);
            startBtn.Location = new Point(600, 280);
            startBtn.Visible = false;

            MaxGain.Location = new Point(730, 500);
            HighGain.Location = new Point(650, 500);
            LowGain.Location = new Point(570, 500);
            MinGain.Location = new Point(490, 500);

            MaxDecibel.Location = new Point(730, 600);
            HighDecibel.Location = new Point(650, 600);
            LowDecibel.Location = new Point(570, 600);
            MinDecibel.Location = new Point(490, 600);

            minSound = new SoundPlayer("C:/Users/minisim/Desktop/Crossmodal-Interface/Sounds/30db.wav");
            lowSound = new SoundPlayer("C:/Users/minisim/Desktop/Crossmodal-Interface/Sounds/60db.wav");
            highSound = new SoundPlayer("C:/Users/minisim/Desktop/Crossmodal-Interface/Sounds/80db.wav");
            maxSound = new SoundPlayer("C:/Users/minisim/Desktop/Crossmodal-Interface/Sounds/100db.wav");

            data = File.ReadAllText("C:/Gaojian/Crossmodal-Interface/Crossmodal Interface/data/data.txt");


           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(1024, 0);
           
            
        }
        private static void InitializeClass()
        {

        }

   

       

        private void nameInput_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //may need to add error checking to see if name already exists!
                this.name = nameInput.Text;
                if (!name.Equals(""))
                {
                    welcomeText.Text = "Hi " + this.name + ", please click start to begin";
                    nameLabel.Visible = false;
                    nameInput.Visible = false;
                    startBtn.Visible = true;
                    data += Environment.NewLine + "name:" + name + Environment.NewLine;
                }
                else
                {
                    welcomeText.Text = "Please enter a name!";
                }
            }
        }

        private void retry_Click(object sender, EventArgs e)
        {
            tactorOn = Discover(1);
            if(tactorOn == 1)
            {
                retry.Visible = false;
                nameInput.Visible = true;
                nameLabel.Visible = true;
                welcomeText.Text = "Welcome to the NHanCE Laboratories Crossmodal Matching Interface\n Enter your full name and press \"Enter\"";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseAll();
            File.WriteAllText("C:/Gaojian/Crossmodal-Interface/Crossmodal Interface/data/data.txt", data);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {

        
            VisualToAuditory va = new VisualToAuditory();
            this.Hide();
            va.SetDesktopLocation(1024, 0);
            va.ShowDialog();
            welcomeText.Text = "";
            auditoryValue = va.getAuditoryValue();
            //results.Text += "Decibel average: " + auditoryValue + Environment.NewLine;
            //data += "Auditory average: " + auditoryValue + Environment.NewLine;
            audioValues[0]= va.getAuditoryValue();

            VisualToTactile vt = new VisualToTactile();
            vt.SetDesktopLocation(1024, 0);
            vt.ShowDialog();
            welcomeText.Text = "";
            tactileValues[0] = vt.getTactileValue();
  
            va.SetDesktopLocation(1024, 0);
            va.ShowDialog();
            audioValues[1] = va.getAuditoryValue();


            vt.SetDesktopLocation(1024, 0);
            vt.ShowDialog();
            tactileValues[1] = vt.getTactileValue();

            va.SetDesktopLocation(1024, 0);
            va.ShowDialog();
            audioValues[2] = va.getAuditoryValue();

            vt.SetDesktopLocation(1024, 0);
            vt.ShowDialog();
            this.Show();
            welcomeText.Text = "You may now close the window";
            tactileValues[2] = vt.getTactileValue();

            startBtn.Visible = false;

            data += "Auditory values: ";
            for(int x = 0; x < 3; x++)
            {
                if(x == 2)
                {
                    data += audioValues[2];
                }
                else
                {
                    data += audioValues[x] + ",";
                }
                
            }

            data += Environment.NewLine + "Auditory Average: " + (int)audioValues.Average();

            data += Environment.NewLine + "Tactile values: ";
            for (int x = 0; x < 3; x++)
            {
                if (x == 2)
                {
                    data += tactileValues[2];
                }
                else
                {
                    data += tactileValues[x] + ",";
                }

            }

            data += Environment.NewLine + "Tactile average: " + (int)tactileValues.Average() + Environment.NewLine;


        }

        private void MinGain_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Discover(1));
            ChangeGain(0, 1, 17, 0);
            ChangeGain(0, 2, 17, 0);
            Pulse(0, 1, 250, 0);
            Pulse(0, 2, 250, 0);

        }

        private void MaxGain_Click(object sender, EventArgs e)
        {
         
            ChangeGain(0, 1, 255, 0);
            ChangeGain(0, 2, 255, 0);
            Pulse(0, 1, 250, 0);
            Pulse(0, 2, 250, 0);
        }

        private void LowGain_Click(object sender, EventArgs e)
        {
            ChangeGain(0, 1,65, 0);
            ChangeGain(0, 2, 65, 0);
            Pulse(0, 1, 250, 0);
            Pulse(0, 2, 250, 0);
        }

        private void HighGain_Click(object sender, EventArgs e)
        {
            ChangeGain(0, 1,195, 0);
            ChangeGain(0, 2,195, 0);
            Pulse(0, 1, 250, 0);
            Pulse(0, 2, 250, 0);
        }

        private void MinDecibel_Click(object sender, EventArgs e)
        {
            minSound.Play();
        }

        private void LowDecibel_Click(object sender, EventArgs e)
        {
            lowSound.Play();
        }

        private void HighDecibel_Click(object sender, EventArgs e)
        {
            highSound.Play();
        }

        private void MaxDecibel_Click(object sender, EventArgs e)
        {
            maxSound.Play();
        }
    }
}
