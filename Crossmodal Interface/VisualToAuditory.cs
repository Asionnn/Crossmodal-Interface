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
            this.redDot.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 80, Screen.PrimaryScreen.WorkingArea.Height / 2 + 30);
            FormBorderStyle = FormBorderStyle.None;
            this.instr.Text = "Use the arrow keys to change the volume of the sound.\nClick \"finish\" when you are done.";
            this.instr.Location = new Point(0, 0);
            this.instr.Font = new Font("Arial", 20, FontStyle.Bold);
            this.finishBtn.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width-80, Screen.PrimaryScreen.WorkingArea.Height);
            this.auditoryIntensity = 0;
        }

        private void VisualToAuditory_Load(object sender, EventArgs e)
        {

        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(e.KeyCode == Keys.Right)
                {
                    //increase volume
                }
                else if(e.KeyCode == Keys.Left)
                {
                    //decrease volume
                }
            
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
