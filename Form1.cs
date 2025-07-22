using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class FlappyBird : Form
    {
        int score = 0;
        int gravity = 10;
        int pipeSpeed = 8;
        bool AlmostEnd = false;
        bool End = false;
        Random randomY= new Random();
        Point StartPos = new Point(41, 219);
        public FlappyBird()
        {
            InitializeComponent();
            timer1.Start();
            lbGameOver.Visible = false;
            btnRestart.Visible = false;
            lbScore.Visible = true;
            lbFinalScores.Visible = false;
        }

     /*   private void FlappyBird_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
            if(e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.LButton)
            {
                bird.Top -= 70;

            }
        }
        */

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (AlmostEnd == false)
            {
                TubeUp.Left -= pipeSpeed;
                TubeDown.Left -= pipeSpeed;
                bird.Top += gravity;
                if (TubeUp.Left < -150)
                {
                    TubeUp.Top = randomY.Next(-250, 0);
                    TubeUp.Left = 700;
                    score++;
                }
                if (TubeDown.Left < -150)
                {
                    TubeDown.Top = TubeUp.Bottom + 160;
                    TubeDown.Left = 700;
                }
                if (bird.Bounds.IntersectsWith(TubeDown.Bounds) || bird.Bounds.IntersectsWith(TubeUp.Bounds) || bird.Bounds.IntersectsWith(pctGronud.Bounds))
                {
                    AlmostEnd = true;
                    //EndGame();
                }
                if (score > 3)
                {
                    pipeSpeed = 10;
                    label1.Text = "Почти нуб";
                    label1.Location = new Point(582, 9);
                    label1.BackColor = Color.SandyBrown;
                }
                if (score > 6)
                {
                    pipeSpeed = 12;
                    label1.Text = "Среднячок";
                    label1.Location = new Point(582, 9);
                    label1.BackColor = Color.Yellow;
                }
                if (score > 10)
                {
                    pipeSpeed = 14;
                    label1.Text = "ПРО";
                    label1.Location = new Point(673, 9);
                    label1.BackColor = Color.Green;
                }
                if (score > 15)
                {
                    pipeSpeed = 16;
                    label1.Text = "Супер-Летун";
                    label1.Location = new Point(550, 9);
                    label1.BackColor = Color.Blue;
                }
                if (score > 18)
                {
                    pipeSpeed = 18;
                    label1.Text = "Босс качалки";
                    label1.Location = new Point(530, 9);
                    label1.BackColor = Color.Purple;
                }
                lbScore.Text = "Score:" + score.ToString();
            }
            else
            {
                gravity = 10;
                bird.Top += gravity;
                if (bird.Bounds.IntersectsWith(pctGronud.Bounds))
                {
                    
                    EndGame();
                    AlmostEnd = false;
                }
            }
        }
        private void EndGame()
        {
            timer1.Stop();
            lbGameOver.Visible = true;
            btnRestart.Visible = true;
            lbScore.Visible = false;
            lbFinalScores.Text += score.ToString();
            lbFinalScores.Visible = true;
            End = true;

        }

        private void FlappyBird_KeyDown(object sender, KeyEventArgs e)
        {
            if (End == false && AlmostEnd == false)
            {
                if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
                {
                    gravity = -10;
                }
            }
        }

        private void FlappyBird_KeyUp(object sender, KeyEventArgs e)
        {
            if (End == false && AlmostEnd == false)
            {
                if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
                {
                    gravity = 10;
                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            /*  timer1.Start();
              score = 0;
              bird.Location = StartPos;
              lbGameOver.Visible = false;
              btnRestart.Visible = false;
              lbScore.Visible = true;
              lbFinalScores.Visible = false;
              TubeDown.Left = 1000;
              TubeUp.Left = 1000;
              lbFinalScores.Text = "Ваши очки:";
              End = false;
              gravity = 10;
            */
            Application.Restart();
        }

        private void FlappyBird_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
