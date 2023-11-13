using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int boruhizi = 8;
        int gravity = 15;
        int score = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

            private void gamekeyisdown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Space)
                {
                    gravity = -15;
                }
            }

            private void gamekeyisup(object sender, KeyEventArgs e)
            {
                if(e.KeyCode== Keys.Space)
                {
                    gravity = 15 ;
                }

            }
         private void endgame()
                {
                    gametimer.Stop();
                    label1.Text = "GAME OVER";
                }
        private void gametimerEvent(object sender, EventArgs e)
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
            if(Paimon.Bounds.IntersectsWith(pictureBox3.Bounds)||
                Paimon.Bounds.IntersectsWith(pictureBox1.Bounds)||
                Paimon.Bounds.IntersectsWith(pictureBox2.Bounds)|| Paimon.Left < -25)
            {
                endgame();
            }

        }
       

    }
}
