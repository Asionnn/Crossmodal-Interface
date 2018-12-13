/*
 * Purpose: Crossmodal Matching Interface for NHanCE Research Lab, Purdue Univeristy
 * 
 * Creator: Collin Hong-da Li
 * 
 * TODO: get example background image from minisim and layer a redDot(200x200) onto it
 * TODO: get the sound file, and change the amplitude
 * TODO: find a way to connect to the tactor to change the vibration intensity
 * 
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
        private string name;

        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            welcomeText.Text = "Welcome to the NHanCE Laboratories Crossmodal Matching Interface\n Enter your full name and press \"Enter\"";
            welcomeText.Font = new Font("Arial", 20, FontStyle.Bold);
            nameLabel.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 130, Screen.PrimaryScreen.WorkingArea.Height / 2 - 195);
            nameInput.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 80, Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);
            VA.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 130, Screen.PrimaryScreen.WorkingArea.Height / 2 - 50);
            VT.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 , Screen.PrimaryScreen.WorkingArea.Height / 2 - 50);
            VA.Visible = false;
            VT.Visible = false;
            exitBtn.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width-500, Screen.PrimaryScreen.WorkingArea.Height - 100);

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
                welcomeText.Text = "Hi " + this.name + ", please press any of the buttons below to start the matching";
                nameLabel.Visible = false;
                nameInput.Visible = false;
                VT.Visible = true;
                VA.Visible = true;
            }
        }

        private void VT_Click_1(object sender, EventArgs e)
        {
            VisualToTactile vt = new VisualToTactile();
            this.Hide();
            vt.ShowDialog();
            this.Show();
            welcomeText.Text = "";
            VT.Visible = false;
            if (!VA.Visible)
            {
                welcomeText.Text = "Thank you for your inputs";
            }
        }

        private void VA_Click(object sender, EventArgs e)
        {
            VisualToAuditory va = new VisualToAuditory();
            this.Hide();
            va.ShowDialog();
            this.Show();
            welcomeText.Text = "";
            VA.Visible = false;
            if (!VT.Visible)
            {
                welcomeText.Text = "Thank you for your inputs";

            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
