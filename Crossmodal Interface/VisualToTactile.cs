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
        public VisualToTactile()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            redDot.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 80, Screen.PrimaryScreen.WorkingArea.Height / 2 + 30);
            instr.Text = "Use a and d to change the vibration intensity.\nClick \"Finish\" when you are done.\nYou will do this 3 times";
            instr.Font = new Font("Arial", 20, FontStyle.Bold);
            finishBtn.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - 80, Screen.PrimaryScreen.WorkingArea.Height);

            tactileIntensity = 0;

        }

        [DllImport("C:/Users/colli/Documents/NHanCE/TactorAPI/TactorInterface.dll")]
        public static extern int Discover(int a);
        [DllImport("C:/Users/colli/Documents/NHanCE/TactorAPI/TactorInterface.dll")]
        public static extern int InitializeTI();
        [DllImport("C:/Users/colli/Documents/NHanCE/TactorAPI/TactorInterface.dll")]
        public static extern IntPtr GetDiscoveredDeviceName(int index);

        private void VisualToTactile_Load(object sender, EventArgs e)
        {
            instr.Text = "" + Discover(0);
        }
      
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Finish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VisualToTactile_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                

            }
            else if (e.KeyCode == Keys.A)
            {

                instr.Text = "heyyyy";
            }
        }

        

        



    }
}
