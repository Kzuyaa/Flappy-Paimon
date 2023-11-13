using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappyy
{
    public partial class Form1 : Form
    {
        int boruhizi = 8;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void endgame()
        {
            gametimer.Stop();
            label1.Text = "GAME OVER";
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            Paimon.Top += gravity;
            pictureBox3.Left -= boruhizi;
            pictureBox1.Left -= boruhizi;
            label1.Text = "Score:" + score;

            if (pictureBox3.Left < -150)
            {
                pictureBox3.Left = 800;
                score++;
            }
            if (pictureBox1.Left < -150)
            {
                pictureBox1.Left = 950;
                score++;
            }
            if (Paimon.Bounds.IntersectsWith(pictureBox3.Bounds) ||
                Paimon.Bounds.IntersectsWith(pictureBox1.Bounds) ||
                Paimon.Bounds.IntersectsWith(pictureBox2.Bounds) || Paimon.Left < -25
                )
            {
                endgame();
            }
        }


    
    }
}
