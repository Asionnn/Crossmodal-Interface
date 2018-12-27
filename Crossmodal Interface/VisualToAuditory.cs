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
namespace Crossmodal_Interface
{
    public partial class VisualToAuditory : Form
    {
        private double auditoryIntensity;
        private SoundPlayer alert;
        private SoundPlayer[] alertIntensities = new SoundPlayer[13];
        private int currentSoundIndex;
        public VisualToAuditory()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            redDot.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 80, Screen.PrimaryScreen.WorkingArea.Height / 2 + 30);
            FormBorderStyle = FormBorderStyle.None;
            instr.Text = "Use a and d keys to change the volume of the sound.\nClick \"Finish\" when you are done.\nYou will do this 3 times";
            instr.Font = new Font("Arial", 20, FontStyle.Bold);
            finishBtn.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width-80, Screen.PrimaryScreen.WorkingArea.Height);
            auditoryIntensity = 0;
            currentSoundIndex = 0;

            int sPos = 0;
            for(int x = 30;x <= 50; x+=10)
            {
                alertIntensities[sPos] = new SoundPlayer("C:/Users/colli/Documents/NHanCE/Sounds/" + x + "db.wav");
                sPos++;
            }
            for(int x = 55;x <= 100; x += 5)
            {
                alertIntensities[sPos] = new SoundPlayer("C:/Users/colli/Documents/NHanCE/Sounds/" + x + "db.wav");
                sPos++;
            }
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
            this.Close();
        }



        private void VisualToAuditory_KeyUp(object sender, KeyEventArgs e)
        {
           
            if(e.KeyCode == Keys.D)
            {
                
                alertIntensities[currentSoundIndex].Play();
                if(!(currentSoundIndex == alertIntensities.Length-1))
                { 
                    currentSoundIndex++;
                    
                }
               
            }
            else if(e.KeyCode == Keys.A)
            {
                if (!(currentSoundIndex == 0))
                {
                    currentSoundIndex--;
                }
               
                alertIntensities[currentSoundIndex].Play();
            }
        }
    }
}
