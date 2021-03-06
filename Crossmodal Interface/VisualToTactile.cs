﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crossmodal_Interface
{
    public partial class VisualToTactile : Form
    {
        private int tactileIntensity;
        private System.Windows.Media.MediaPlayer p1 = new System.Windows.Media.MediaPlayer();
        private int temp;


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
        

        public VisualToTactile()
        {
            
            
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            //FormBorderStyle = FormBorderStyle.None;
            redDot.Location = new Point(600, 512);
            instr.Text = "Use the left and right arrow keys to change the vibration intensity.\nClick \"Submit\" when you are done.";
            instr.Font = new Font("Arial", 20, FontStyle.Bold);
            submitBtn.Location = new Point(0, 0);

            //connect to Tactors
            //InitializeTI();
            //Discover(1);
            string name = Marshal.PtrToStringAnsi((IntPtr)GetDiscoveredDeviceName(0));
            Connect(name, 1, IntPtr.Zero);
            ChangeGain(0, 1, 1, 0);
            ChangeGain(0, 2, 1, 0);


            tactileIntensity = 0;


            p1.Open(new System.Uri(@"C:/Gaojian/Crossmodal-Interface/Sounds/background.wav"));
            p1.Play();

        }

       

        private void VisualToTactile_Load(object sender, EventArgs e)
        {
            p1.Play();
        }
      
     

      


        private void VisualToTactile_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                if(tactileIntensity >= 255)
                {
                    tactileIntensity = 255;
                }
                else
                {
                    tactileIntensity += 17;
                }
                
                ChangeGain(0, 1, tactileIntensity, 0);
                ChangeGain(0, 2, tactileIntensity, 0);
                Pulse(0, 1, 250, 0);
                Pulse(0, 2, 250, 0);
               

            }
            else if (e.KeyCode == Keys.Left)
            {
                if(tactileIntensity <= 17)
                {
                    tactileIntensity = 17;

                }
                else
                {
                    tactileIntensity -= 17;
                }
              
                ChangeGain(0, 1, tactileIntensity, 0);
                ChangeGain(0, 2, tactileIntensity, 0);
                Pulse(0, 1, 250, 0);
                Pulse(0, 2, 250, 0);
            }
        }

        private void redDot_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            temp = tactileIntensity;
            tactileIntensity = 0;
            p1.Stop();
            this.Close();

        }

        public int getTactileValue()
        {
            return temp;
        }
    
    }
}
