﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace Crossmodal_Interface
{
    public partial class VisualToAuditory : Form
    {
        private int auditoryIntensity;
        private SoundPlayer[] alertIntensities = new SoundPlayer[13];
        private int currentSoundIndex;
        private int[] data = new int[3];
        private int[] decibelLevels = new int[13];
        private int testCounter;
        private System.Windows.Media.MediaPlayer p1 = new System.Windows.Media.MediaPlayer();


        public VisualToAuditory()
        {
        
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
           
            redDot.Location = new Point(600,512);
            //FormBorderStyle = FormBorderStyle.None;
            instr.Text = "Use a and d keys to change the volume of the sound.\nClick \"Submit\" when you are done.\nYou will do this 3 times";
            instr.Font = new Font("Arial", 20, FontStyle.Bold);
            submitBtn.Location = new Point(0,0);
            auditoryIntensity = 0;
            currentSoundIndex = 0;
            testCounter = 0;
            int sPos = 0;

            for(int x = 30;x <= 50; x+=10)
            {
                decibelLevels[sPos] = x;
                alertIntensities[sPos] = new SoundPlayer("C:/Users/minisim/Desktop/Crossmodal-Interface/Sounds/" + x + "db.wav");
                sPos++;
            }
            for(int x = 55;x <= 100; x += 5)
            {
                decibelLevels[sPos] = x;
                alertIntensities[sPos] = new SoundPlayer("C:/Users/minisim/Desktop/Crossmodal-Interface/Sounds/" + x + "db.wav");
                sPos++;
            }

            p1.Open(new System.Uri(@"C:/Users/minisim/Desktop/Crossmodal-Interface/Sounds/background.wav"));
            p1.Play();

        }

  

        private void VisualToAuditory_Load(object sender, EventArgs e)
        {
            
        }

        private void VisualToAuditory_KeyUp(object sender, KeyEventArgs e)
        {
           
            if(e.KeyCode == Keys.D)
            {
                
                
                if(!(currentSoundIndex == alertIntensities.Length-1))
                { 
                    currentSoundIndex++;
                    
                }
                alertIntensities[currentSoundIndex].LoadAsync();
                alertIntensities[currentSoundIndex].Play();
               


            }
            else if(e.KeyCode == Keys.A)
            {
                
                if (!(currentSoundIndex == 0))
                {
                    currentSoundIndex--;
                }
                alertIntensities[currentSoundIndex].LoadAsync();
                alertIntensities[currentSoundIndex].Play();
                
            }
        }

        public int getAuditoryValue()
        {
            return auditoryIntensity;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            data[testCounter] = decibelLevels[currentSoundIndex];
            testCounter++;
            instr.Text = "" + testCounter + "/3 tests done";
            if (testCounter == 3)
            {
                auditoryIntensity = (int)data.Average();
                p1.Stop();
                this.Close();
            }
            currentSoundIndex = 0;
        }
    }
}
