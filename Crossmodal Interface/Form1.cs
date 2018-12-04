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
       


      
        public Form1()
        {
            InitializeComponent();
            count = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private static void InitializeClass()
        {

        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            //This method is used to control the intensity of the VAT signals
            label1.Visible = true;
            label1.Font = new Font(label1.Font.FontFamily, 16);

            if (e.KeyCode == Keys.Right)
            {
              
                label1.Text = count.ToString();
            }
            else if(e.KeyCode == Keys.Left)
            {
                
                if (count == 0)
                {
                    //prevent negative value
                    count = 0;
               
                }
                else {
                    //decrement signal values
                    count--;
     
                    label1.Text = count.ToString();
                }     
            }
        }

        private void VA_Click(object sender, EventArgs e)
        {
            VisualToAuditory va = new VisualToAuditory();
            this.Hide();
            va.ShowDialog();
            this.Show();

        }

        private void VT_Click(object sender, EventArgs e)
        {
            VisualToTactile va = new VisualToTactile();
            this.Hide();
            va.ShowDialog();
            this.Show();
        }

        private void AV_Click(object sender, EventArgs e)
        {
            AuditoryToVisual va = new AuditoryToVisual();
            this.Hide();
            va.ShowDialog();
            this.Show();
        }

        private void AT_Click(object sender, EventArgs e)
        {
            AuditoryToTactile va = new AuditoryToTactile();
            this.Hide();
            va.ShowDialog();
            this.Show();
        }

        private void TA_Click(object sender, EventArgs e)
        {
            TactileToAuditory va = new TactileToAuditory();
            this.Hide();
            va.ShowDialog();
            this.Show();
        }

        private void TV_Click(object sender, EventArgs e)
        {
            TactileToVisual va = new TactileToVisual();
            this.Hide();
            va.ShowDialog();
            this.Show();
        }

    }
}
