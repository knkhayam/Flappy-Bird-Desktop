using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace flappy_bird
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            btnsCreator();
        }
        static int totalButtons = 4;
        PictureBox[] btnsUps = new PictureBox[totalButtons];
        PictureBox[] btnsDwn = new PictureBox[totalButtons];
        int foreLeft = 0;
        int btnWidth = 60;
        int horizontalGap = 200;
        int Hscore = 0;
        int fallTmr2x = 0;

        private void btnsRemover()
        {
            for(int n=0;n<totalButtons;n++)
            {
                this.Controls.Remove(btnsUps[n]);
                this.Controls.Remove(btnsDwn[n]);
            }
        }

        private int random()
        {
            Random rnd = new Random();
            return rnd.Next(-80, 80);
        }

        private void btnsCreator()
        {
            for(int n=0,horGap=0,verPos=10;n<totalButtons;n++,horGap+=horizontalGap,verPos=random())
            {
                btnsUps[n] = new PictureBox();
                btnsDwn[n] = new PictureBox();
                btnsUps[n].Location = new Point(500+horGap, -5);
                btnsDwn[n].Location = new Point(500+horGap, 195+verPos);
                btnsUps[n].Size = new Size(btnWidth, 120+verPos);
                btnsDwn[n].Size = new Size(btnWidth, 120-verPos);
                btnsUps[n].ImageLocation = @"Images/pole.png";
                btnsDwn[n].ImageLocation = @"Images/pole ulta.png";
                this.Controls.Add(btnsUps[n]);
                this.Controls.Add(btnsDwn[n]);
               
            }
            
        }

        private void jump()
        {
            fallTimer.Enabled = true;
            runSpeed.Enabled = true;
            tmr.Interval = 1;
            tmr.Enabled = true;
            
        }

        
        private void tmr_Tick(object sender, EventArgs e)
        {

            character.Top-=2;
            tmr.Interval += 2;
            if (tmr.Interval > 25)
                tmr.Enabled = false;
        }

        
        private void fallTimer_Tick(object sender, EventArgs e)
        {
            if (tmr.Enabled == true)
            {
                fallTimer.Interval = 30;
                fallTmr2x = 0;
                return;
            }
            character.Top++;
            if (fallTimer.Interval > 3)
                fallTimer.Interval -= 3;
            else if (fallTmr2x <= 6)
            {
                character.Top++;
                fallTmr2x++;
            }
            else
                character.Top += 2;
            validator();
        }

        private void reset()
        {
            fallTimer.Enabled = false;
            runSpeed.Enabled = false;
            character.Top = 170;
            btnsRemover();
            btnsCreator();
            foreLeft = 0;
            score.Text = "0";
            Hscore = 0;
        }

        private void validator()
        {
            
            if(character.Top >= 260)
            {
                reset();
                MessageBox.Show("Crashed... You Lost..");
            }
            else if ((character.Left + character.Size.Width) >= btnsUps[foreLeft].Left && character.Left <= (btnsUps[foreLeft].Left + btnWidth))
            {
                
                    
                if ((character.Top >= (btnsUps[foreLeft].Top + btnsUps[foreLeft].Size.Height)) && (character.Top + character.Size.Height) <= btnsDwn[foreLeft].Top)
                {
                    return;
                }
                reset();
                MessageBox.Show("Collision...");
               
                
            }
        }

        private void runSpeed_Tick(object sender, EventArgs e)
        {
            for (int n = 0,verPos=random(); n < totalButtons; n++)
            {
                btnsUps[n].Left--;
                btnsDwn[n].Left--;
                if(btnsUps[foreLeft].Left <= -btnWidth)
                {
                    btnsUps[foreLeft].Left = (horizontalGap * (totalButtons)) - btnWidth;
                    btnsDwn[foreLeft].Left = (horizontalGap*(totalButtons))- btnWidth;
                    btnsDwn[foreLeft].Location = new Point(btnsDwn[foreLeft].Location.X, 250 + verPos);
                    btnsUps[n].Size = new Size(btnWidth, 120 + verPos);
                    btnsDwn[n].Size = new Size(btnWidth, 120 - verPos);
                    foreLeft++;
                    if (foreLeft == totalButtons)
                    {
                        foreLeft = 0;
                    }
                }
            }
            if ((character.Left + character.Size.Width) == (btnsUps[foreLeft].Left + 10))
            {
                Hscore++;
                score.Text = Hscore.ToString();
            }
        }

        private void mainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                jump();
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
