using System;
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
        private SoundPlayer backgroundNoise;
        private int currentSoundIndex;
        private int[] data = new int[3];
        private int[] decibelLevels = new int[13];
        private int testCounter;

        public VisualToAuditory()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            redDot.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 80, Screen.PrimaryScreen.WorkingArea.Height / 2 + 30);
            FormBorderStyle = FormBorderStyle.None;
            instr.Text = "Use a and d keys to change the volume of the sound.\nClick \"Finish\" when you are done.\nYou will do this 3 times";
            instr.Font = new Font("Arial", 20, FontStyle.Bold);
            submitBtn.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width-80, Screen.PrimaryScreen.WorkingArea.Height);
            auditoryIntensity = 0;
            currentSoundIndex = 0;
            testCounter = 0;

            int sPos = 0;

            for(int x = 30;x <= 50; x+=10)
            {
                decibelLevels[sPos] = x;
                alertIntensities[sPos] = new SoundPlayer("C:/Users/colli/Documents/NHanCE/Sounds/" + x + "db.wav");
                sPos++;
            }
            for(int x = 55;x <= 100; x += 5)
            {
                decibelLevels[sPos] = x;
                alertIntensities[sPos] = new SoundPlayer("C:/Users/colli/Documents/NHanCE/Sounds/" + x + "db.wav");
                sPos++;
            }

            //backgroundNoise = new SoundPlayer("C:/Users/colli/Documents/NHanCE/Sounds/background.wav");
            var p1 = new System.Windows.Media.MediaPlayer();
            p1.Open(new System.Uri(@"C:/Users/colli/Documents/NHanCE/Sounds/background.wav"));
            p1.Play();

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
            data[testCounter] = decibelLevels[currentSoundIndex];
            testCounter++;
            instr.Text = "" + currentSoundIndex;
            if(testCounter == 3)
            {
                auditoryIntensity = (int)data.Average();
                this.Close();
            }
            currentSoundIndex = 0;
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
    }
}
