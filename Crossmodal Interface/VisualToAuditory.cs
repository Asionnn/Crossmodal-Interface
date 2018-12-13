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
        public VisualToAuditory()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.redDot.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 80, Screen.PrimaryScreen.WorkingArea.Height / 2 + 20);
            this.exitBtn.Location = new Point(0, 0);
            FormBorderStyle = FormBorderStyle.None;
           
        }

        private void VisualToAuditory_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
