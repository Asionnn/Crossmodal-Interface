/*
 * Purpose: Crossmodal Matching Interface for NHanCE Research Lab
 * 
 * Author: Collin Hong-da Li
 * 
 * Purdue University
 * 
 * 
 * NOTES
 * TODO
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
        private string name;

        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            VT.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 50, Screen.PrimaryScreen.WorkingArea.Height / 2 - 50);
            TA.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 300, Screen.PrimaryScreen.WorkingArea.Height / 2 - 50);
            AV.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 + 200, Screen.PrimaryScreen.WorkingArea.Height / 2 - 50);
            welcomeText.Text = "Welcome to the NHanCE Laboratories Crossmodal Matching Interface\n Enter your full name and press \"Enter\"";
            welcomeText.Font = new Font("Arial", 20, FontStyle.Bold);
            VT.Visible = false;
            AV.Visible = false;
            TA.Visible = false;
            nameLabel.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 100, Screen.PrimaryScreen.WorkingArea.Height / 2 - 195);
            nameInput.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 50, Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
        private static void InitializeClass()
        {

        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //may need to add error checking to see if name already exists!
                this.name = nameInput.Text;
                VT.Visible = true;
                AV.Visible = true;
                TA.Visible = true;
                welcomeText.Text = "Hi " + this.name + ", please press any of the buttons below to start the matching";
                nameLabel.Visible = false;
                nameInput.Visible = false;
            }
        }

        private void VT_Click(object sender, EventArgs e)
        {
            VisualToTactile va = new VisualToTactile();
            this.Hide();
            va.ShowDialog();
            this.Show();
            welcomeText.Text = "";
            VT.Visible = false;
            if(!AV.Visible && !TA.Visible)
            {
                welcomeText.Text = "Done! Thank you for your inputs.\n You may now close this window";
            }
        }

        private void AV_Click(object sender, EventArgs e)
        {
            AuditoryToVisual vt = new AuditoryToVisual();
            this.Hide();
            vt.ShowDialog();
            this.Show();
            welcomeText.Text = "";
            AV.Visible = false;
            if (!VT.Visible && !TA.Visible)
            {
                welcomeText.Text = "Done! Thank you for your inputs.\n You may now close this window";
            }
        }

        private void TA_Click(object sender, EventArgs e)
        {
            TactileToAuditory ta = new TactileToAuditory();
            this.Hide();
            ta.ShowDialog();
            this.Show();
            welcomeText.Text = "";
            TA.Visible = false;
            if (!AV.Visible && !VT.Visible)
            {
                welcomeText.Text = "Done! Thank you for your inputs.\n You may now close this window";
            }
        }
    }
}
