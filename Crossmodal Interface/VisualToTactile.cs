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
    public partial class VisualToTactile : Form
    {
        public VisualToTactile()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
         
            this.redDot.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 80, Screen.PrimaryScreen.WorkingArea.Height / 2 + 30);

        }

        private void VisualToTactile_Load(object sender, EventArgs e)
        {

        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Right)
                {
                    //increase vibration
                }
                else if (e.KeyCode == Keys.Left)
                {
                    //decrease
                }

            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
