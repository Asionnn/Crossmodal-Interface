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
    public partial class AuditoryToVisual : Form
    {
        private int count = 1;
        private Size size1 = new Size(100, 100);
        private Size size2 = new Size(200, 200);
        private Size size3 = new Size(300, 300);
        public AuditoryToVisual()
        {
            InitializeComponent();
            redDot.Size = size1;
            WindowState = FormWindowState.Maximized;
            redDot.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 50, Screen.PrimaryScreen.WorkingArea.Height / 2 - 50);
        }

        private void AuditoryToVisual_Load(object sender, EventArgs e)
        {

        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            //This method is used to control the size
            if (e.KeyCode == Keys.Right)
            {
                if (!(count == 3))
                {
                    count++;
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (!(count == 1))
                {
                    count--;
                }
            }
            switch (count)
            {
                case 1:
                    redDot.Size = size1;
                    redDot.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 50, Screen.PrimaryScreen.WorkingArea.Height / 2 - 50);

                    break;
                case 2:
                    redDot.Size = size2;
                    redDot.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 100, Screen.PrimaryScreen.WorkingArea.Height / 2 - 100);

                    break;
                case 3:
                    redDot.Size = size3;
                    redDot.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 150, Screen.PrimaryScreen.WorkingArea.Height / 2 - 150);
                    break;     
            }
        }
}
}
