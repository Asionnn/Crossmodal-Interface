/*
 * Purpose: Crossmodal Matching Interface for NHanCE Research Lab
 * 
 * Author: Collin Hong-da Li
 * 
 * Purdue University
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

namespace Crossmodal_Interface
{
    //class for specific user intensities*

    public partial class Form1 : Form
    {

        private List<UserInfo> users;
        private int count;
        private int visualIntensity;
        private int auditoryIntensity;
        private int tactileIntensity;

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        private System.Media.SoundPlayer sound;

        private static bool initialized = false;
        private static Int32 hdc;
        private static int a;

        private Boolean addUser = false;
        private Boolean next = false;
        private int max = 3;


        //used to communicate with the computer sound controls
        /*[DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);
        //
        [DllImport("GDI32.dll")]
        private unsafe static extern bool SetDeviceGammaRamp(Int32 hdc, void* ramp);
        */
        public Form1()
        {
            InitializeComponent();
            this.count = 0;
            sound = new System.Media.SoundPlayer(@"C:\Users\colli\Documents\NHanCE\chime.wav");
            users = new List<UserInfo>();
           // SetBrightness(0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private static void InitializeClass()
        {
            if (initialized)
                return;
            hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc().ToInt32();
            initialized = true;
        }
       /* public static unsafe bool SetBrightness(int brightness)
        {
            InitializeClass();
            if (brightness > 255)
                brightness = 255;
            if (brightness < 0)
                brightness = 0;
            short* gArray = stackalloc short[3 * 256];
            short* idx = gArray;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 256; i++)
                {
                    int arrayVal = i * (brightness + 128);
                    if (arrayVal > 65535)
                        arrayVal = 65535;
                    *idx = (short)arrayVal;
                    idx++;
                }
            }
            bool retVal = SetDeviceGammaRamp(hdc, gArray);
            return retVal;
        }
        */

        protected override void OnKeyUp(KeyEventArgs e)
        {
            //This method is used to control the intensity of the VAT signals
            label1.Visible = true;
            label1.Font = new Font(label1.Font.FontFamily, 16);
            if (e.KeyCode == Keys.Right)
            {
                count++;
                visualIntensity += 5;
                label1.Text = count.ToString();

               // SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                //(IntPtr)APPCOMMAND_VOLUME_UP);
            }
            else if(e.KeyCode == Keys.Left)
            {
                
                if (count == 0 || visualIntensity == 0)
                {
                    //prevent negative value
                    count = 0;
                    visualIntensity = 0;
                }
                else {
                    //decrement signal values
                    count--;
                    visualIntensity -= 5;
                    label1.Text = count.ToString();
                }

               // SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                //(IntPtr)APPCOMMAND_VOLUME_DOWN);
      
            }
            /*uncomment in the future*/
            //a = visualIntensity;
            //SetBrightness(a);
            //sound.Play();
            
      
            visual.Visible = !visual.Visible;
        }

        //new user method
        private void button1_Click(object sender, EventArgs e)
        {
            addUser = true;
           
        }
    }
}
