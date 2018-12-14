using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crossmodal_Interface
{
    public partial class VisualToAuditory : Form
    {
        private double auditoryIntensity;
        public VisualToAuditory()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            redDot.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 80, Screen.PrimaryScreen.WorkingArea.Height / 2 + 30);
            FormBorderStyle = FormBorderStyle.None;
            instr.Text = "Use the a & d keys to change the volume of the sound.\nClick \"Finish\" when you are done.\nYou will do this 3 times";
            instr.Font = new Font("Arial", 20, FontStyle.Bold);
            finishBtn.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width-80, Screen.PrimaryScreen.WorkingArea.Height);
            auditoryIntensity = 0;
        }

        private void VisualToAuditory_Load(object sender, EventArgs e)
        {

        }
    
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VisualToAuditory_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D)
            {
                //increase volume
                
            }
            else if(e.KeyCode == Keys.A)
            {
                
                //decrease volume
            }
        }
    }
}
