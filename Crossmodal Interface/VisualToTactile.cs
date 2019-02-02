using System;
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
        private int testCounter;
        private int[] data = new int[3];
        private int avg;
        private System.Windows.Media.MediaPlayer p1 = new System.Windows.Media.MediaPlayer();


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
            instr.Text = "Use a and d to change the vibration intensity.\nClick \"Submit\" when you are done.\nYou will do this 3 times";
            instr.Font = new Font("Arial", 20, FontStyle.Bold);
            submitBtn.Location = new Point(0, 0);

            //connect to Tactors
            //InitializeTI();
            //Discover(1);
            string name = Marshal.PtrToStringAnsi((IntPtr)GetDiscoveredDeviceName(0));
            Connect(name, 1, IntPtr.Zero);
            ChangeGain(0, 1, 1, 0);
            ChangeGain(0, 1, 1, 0);


            tactileIntensity = 0;
            testCounter = 0;

            p1.Open(new System.Uri(@"C:/Users/minisim/Desktop/Crossmodal-Interface/Sounds/background.wav"));
            p1.Play();

        }

       

        private void VisualToTactile_Load(object sender, EventArgs e)
        {
         
        }
      
     

      


        private void VisualToTactile_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D)
            {
                if(tactileIntensity >= 255)
                {
                    tactileIntensity = 255;
                }
                else
                {
                    tactileIntensity += 5;
                }
                
                ChangeGain(0, 1, tactileIntensity, 0);
                ChangeGain(0, 2, tactileIntensity, 0);
                Pulse(0, 1, 250, 0);
                Pulse(0, 2, 250, 0);
               

            }
            else if (e.KeyCode == Keys.A)
            {
                if(tactileIntensity <= 5)
                {
                    tactileIntensity = 5;
                }
                else
                {
                    tactileIntensity -= 5;
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
            data[testCounter] = tactileIntensity;
            testCounter++;
            instr.Text = "" + testCounter + "/3 tests done";
            if (testCounter == 3)
            {
                avg = (int)data.Average();
                p1.Stop();
                this.Close();
            }
            tactileIntensity = 0;
        }

        public int getTactileValue()
        {
            return avg;
        }
    
    }
}
