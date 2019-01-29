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
        private int auditoryValue;
        private int tactileValue;

        public Form1()
        {
            this.Location = new Point(1280, 24);
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            welcomeText.Text = "Welcome to the NHanCE Laboratories Crossmodal Matching Interface\n Enter your full name and press \"Enter\"";
            welcomeText.Font = new Font("Arial", 20, FontStyle.Bold);
            results.Text = "";
            results.Font = new Font("Arial", 20, FontStyle.Bold);
            nameLabel.Location = new Point(580,250);
            nameInput.Location = new Point(620,250);
            VA.Location = new Point(480,300);
            VT.Location = new Point(720,300);
            VA.Visible = false;
            VT.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
        private static void InitializeClass()
        {

        }

        private void VT_Click_1(object sender, EventArgs e)
        {
            VisualToTactile vt = new VisualToTactile();
            this.Hide();
            vt.ShowDialog();
            this.Show();
            welcomeText.Text = "";
            VT.Visible = false;
            tactileValue = vt.getTactileValue();
            results.Text += "Tactile average: " + tactileValue + "\n";
            
            
            
        }

        private void VA_Click(object sender, EventArgs e)
        {
            VisualToAuditory va = new VisualToAuditory();
            this.Hide();
            va.ShowDialog();
            this.Show();
            welcomeText.Text = "";
            VA.Visible = false;
        
            auditoryValue = va.getAuditoryValue();
            results.Text += "Decibel average: " + auditoryValue + "\n";
        }

        private void nameInput_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //may need to add error checking to see if name already exists!
                this.name = nameInput.Text;
                if (!name.Equals(""))
                {
                    welcomeText.Text = "Hi " + this.name + ", please click on any of the buttons below to start matching";
                    nameLabel.Visible = false;
                    nameInput.Visible = false;
                    VT.Visible = true;
                    VA.Visible = true;
                }
                else
                {
                    welcomeText.Text = "Please enter a name!";
                }
            }
        }
    }
}
