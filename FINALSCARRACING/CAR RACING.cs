using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace FINALSCARRACING
{
    public partial class CAR_RACING : Form
    {
        System.Timers.Timer timer;
        int h, m, s, ms;

        int roadSpeed = 15;
        int trafficSpeed = 15;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();
        bool goleft, goright;

        public CAR_RACING()
        {
            InitializeComponent();
        }

        private void restartGame(object sender, EventArgs e)
        {
            resetGame();
        }
        private void resetGame() 
        {
            btnStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goleft = false;
            goright = false;
            btnSettings.Enabled = false;
            score = 0;
            award.Image = Properties.Resources.bronze_png;
            roadSpeed = 12;
            trafficSpeed = 15;
            A1.Top = carPosition.Next(200, 500) * -1;
            A1.Top = carPosition.Next(5, 200);
            A2.Top = carPosition.Next(200, 500) * -1;
            A1.Top = carPosition.Next(245, 422);
            gametimer.Start();
            timer.Start();
            h = 0;
            m = 0;
            s = 0;
            ms = 0;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            textScore.Text = "SCORE: " + score;
            score++;

            if (goleft == true && player.Left > 10)
            {
                player.Left -= playerSpeed;
            }
            if (goright == true && player.Left < 415)
            {
                player.Left += playerSpeed;
            }


            roadtrack1.Top += roadSpeed;
            roadtrack2.Top += roadSpeed;

            if (roadtrack2.Top > 519)
            {
                roadtrack2.Top = -519;
            }
            if (roadtrack1.Top > 519)
            {
                roadtrack1.Top = -519;
            }

            A1.Top += trafficSpeed;
            A2.Top += trafficSpeed;

            if (A1.Top > 530)
            {
                ChangeACars(A1);
            }
            if (A2.Top > 530)
            {
                ChangeACars(A2);
            }

            if (player.Bounds.IntersectsWith(A1.Bounds) || player.Bounds.IntersectsWith(A2.Bounds))
            {
                gameOver();
            }
            if (score > 40 && score< 500)
            {
                award.Image = Properties.Resources.bronze_png;
            }
            if (score > 500 && score < 2000)
            {
                award.Image = Properties.Resources.silver_png;
                roadSpeed = 20;
                trafficSpeed = 22;
            }
            if (score > 2000)
            {
                award.Image = Properties.Resources.gold_png;
                roadSpeed = 27;
                trafficSpeed = 25;
            }
        }

        private void gameOver() 
        {
            gametimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;
            award.Visible = true;
            award.BringToFront();
            btnStart.Enabled = true;
            timer.Stop();
            btnSettings.Enabled = true;
            lblLastScore.Text = textScore.Text;
            lblLastTime.Text = stopWatch.Text;
        }

        private void ChangeACars(PictureBox tempCar)
        {
            carImage = rand.Next(1, 7);
        
            switch (carImage)
            {
            case 1:
            tempCar.Image = Properties.Resources.ambulance;
            break;
            
            case 2:
            tempCar.Image = Properties.Resources.cargreen;
            break;

            case 3:
            tempCar.Image = Properties.Resources.cargrey;
            break;

            case 4:
            tempCar.Image = Properties.Resources.carorang;
            break;

            case 5:
            tempCar.Image = Properties.Resources.carpink;
            break;

            case 6:
            tempCar.Image = Properties.Resources.carred;
            break;

            case 7:
            tempCar.Image = Properties.Resources.truckblue;
            break;

            case 8:
            tempCar.Image = Properties.Resources.truckwhite;
            break;
            }
            tempCar.Top = carPosition.Next(100, 400) * -1;
            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true; 
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void picCar1_Click(object sender, EventArgs e)
        {
            player.Image = Properties.Resources.truckwhite;
            grpBxCars.Visible = false;
        }

        private void picCar2_Click(object sender, EventArgs e)
        {
            player.Image = Properties.Resources.carorang;
            grpBxCars.Visible = false;
        }

        private void picCar3_Click(object sender, EventArgs e)
        {
            player.Image = Properties.Resources.carpink;
            grpBxCars.Visible = false;
        }

        private void picCar4_Click(object sender, EventArgs e)
        {
            player.Image = Properties.Resources.carred;
            grpBxCars.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            grpBxCars.BringToFront();
            grpBxCars.Visible = true;
        }
        private void CAR_RACING_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1;
            timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>{

                ms += 1;
                if (ms == 100)
                {
                    ms = 0;
                    s += 1;
                }
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }

                stopWatch.Text = string.Format("{0}:{1}:{2}:{3}", h.ToString().ToString().PadLeft(2,'0'), m.ToString().ToString().PadLeft(2,'0'), s.ToString().ToString().PadLeft(2,'0'), ms.ToString().ToString().PadLeft(2,'0'));

            }));
        }
    }
}
