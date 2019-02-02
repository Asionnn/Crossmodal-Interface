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

namespace Crossmodal_Interface
{
    //class for specific user intensities*

    public partial class Form1 : Form
    {
        private string name;
        private int auditoryValue;
        private int tactileValue;
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

        private int tactorOn;
        public Form1()
        {
            this.Location = new Point(1280, 24);
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            InitializeTI();
            tactorOn = Discover(1);
            

            
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
            nameLabel.Location = new Point(580,250);
            nameInput.Location = new Point(620,250);
            results.Location = new Point(0, 0);
            VA.Location = new Point(480,300);
            VT.Location = new Point(720,300);
            VA.Visible = false;
            VT.Visible = false;

            data = File.ReadAllText("C:/Users/minisim/Desktop/Crossmodal-Interface/data.txt");

           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(1024, 0);
           
            
        }
        private static void InitializeClass()
        {

        }

        private void VT_Click_1(object sender, EventArgs e)
        {
            VisualToTactile vt = new VisualToTactile();
            this.Hide();
            vt.SetDesktopLocation(1024, 0);
            vt.ShowDialog();
            this.Show();
            welcomeText.Text = "";
            VT.Visible = false;
            tactileValue = vt.getTactileValue();
            results.Text += "Tactile average: " + tactileValue + Environment.NewLine;
            data += "Tactile average: " + tactileValue + Environment.NewLine;
            
            
            
        }

        private void VA_Click(object sender, EventArgs e)
        {
            VisualToAuditory va = new VisualToAuditory();
            this.Hide();
            va.SetDesktopLocation(1024, 0);
            va.ShowDialog();
            this.Show();
            welcomeText.Text = "";
            VA.Visible = false;
            auditoryValue = va.getAuditoryValue();
            results.Text += "Decibel average: " + auditoryValue + Environment.NewLine;
            data += "Auditory average: " + auditoryValue + Environment.NewLine;
        }

        private void nameInput_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //may need to add error checking to see if name already exists!
                this.name = nameInput.Text;
                if (!name.Equals(""))
                {
                    welcomeText.Text = "Hi " + this.name + ", please click on any of the buttons below to start matching";
                    nameLabel.Visible = false;
                    nameInput.Visible = false;
                    VT.Visible = true;
                    VA.Visible = true;
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
            File.WriteAllText("C:/Users/minisim/Desktop/Crossmodal-Interface/data.txt", data);
        }
    }
}
