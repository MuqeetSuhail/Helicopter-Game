using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Helicopter_Game_Assignment
{
    public partial class Form1 : Form
    {
        private int speed = 30;
        private int MaxHeight;
        private int Jump = 13;
        private int Score = 0;
        private int HighScore;
        private bool spaceButtonHeldDown;
        private bool LeftButtonHeldDown;
        private SoundPlayer startsoundPlayer;
        private SoundPlayer HelicoptersoundPlayer;
        private SoundPlayer ExplosionsoundPlayer;
        public Form1()
        {
            InitializeComponent();
            timer_Clock.Stop();
            MaxHeight = this.Size.Height;
            HighScore = ReadHighScore();
            label_BestScore.Text = "Best Score: " + HighScore.ToString();
            label_BestScore.Hide();
            label_Score.Hide();
            panel_bottomwall.Hide();
            panel_topwall.Hide();
            panel_leftwall.Hide();
            panel_rightwall.Hide();
            pictureBox_Helicopter.Hide();
            pictureBox_Hurdle.Hide();
            pictureBox_CrashedCopter.Hide();
            panel_bottomwall.Height = 10;
        }

        public void RandomHurdleGenerator(PictureBox pic)
        {
            timer_Clock.Stop();
            pic.Hide();
            Point oldLocation = pic.Location;
            Random randomPointGenerator = new Random();
            int xaxis = this.Width;
            int Yaxis = 0;
            Point NewLocation;

        RegenerateIndex:
            Yaxis = randomPointGenerator.Next(35, this.MaxHeight - 100);
            NewLocation = new Point(xaxis, Yaxis);

            if (NewLocation.Y == oldLocation.Y)
            {
                goto RegenerateIndex;
            }
            else
            {
                pic.Location = NewLocation;
            }
            CheckWallCollisionWithHurdle(pic);

            pic.Show();
            timer_Clock.Start();
        }
        public void CheckWallCollisionWithHurdle(PictureBox picture_hurdle)
        {
            if (picture_hurdle.Bounds.IntersectsWith(panel_topwall.Bounds))
            {
                RandomHurdleGenerator(picture_hurdle);
            }
            else if (picture_hurdle.Bounds.IntersectsWith(panel_bottomwall.Bounds))
            {
                RandomHurdleGenerator(picture_hurdle);
            }
        }

        private void MoveHurdle(PictureBox pictureBox_ob)
        {
            if (pictureBox_ob.Bounds.IntersectsWith(panel_leftwall.Bounds))
            {
                RandomHurdleGenerator(pictureBox_ob);
                Score++;
            }
            else
            {
                Point Newpoint = new Point(pictureBox_ob.Location.X - speed, pictureBox_ob.Location.Y);
                pictureBox_ob.Location = Newpoint;
            }
        }
        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            CheckWallCollisionWithHurdle(pictureBox_Hurdle);
            MoveHurdle(pictureBox_Hurdle);

            if (spaceButtonHeldDown == true || LeftButtonHeldDown == true)
            {
                pictureBox_Helicopter.Location = new Point(pictureBox_Helicopter.Location.X, pictureBox_Helicopter.Location.Y - Jump);
            }
            else
            {
                pictureBox_Helicopter.Location = new Point(pictureBox_Helicopter.Location.X, pictureBox_Helicopter.Location.Y + Jump);
            }
            label_Score.Text = "Current Score: " + Score;
            gameOver();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                spaceButtonHeldDown = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            spaceButtonHeldDown = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LeftButtonHeldDown = true;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            LeftButtonHeldDown = false;
        }

        private void gameOver()
        {
            
            if (pictureBox_Helicopter.Bounds.IntersectsWith(pictureBox_Hurdle.Bounds))
            {
                HelicoptersoundPlayer.Stop();
                StartExplosionSound();
                timer_Clock.Stop();
                pictureBox_Helicopter.Hide();
                pictureBox_CrashedCopter.Show();
                panel_bottomwall.Height = 65;
                panel_bottomwall.BackColor = Color.Sienna;
                MessageBox.Show("Game Over!!, Your Score:" + Score);
                HighScore = Score;
                saveHighScore();
                Application.Restart();
            }
            else if (pictureBox_Helicopter.Bounds.IntersectsWith(panel_topwall.Bounds))
            {
                HelicoptersoundPlayer.Stop();
                StartExplosionSound();
                timer_Clock.Stop();
                pictureBox_Helicopter.Hide();
                panel_bottomwall.Height = 65;
                pictureBox_CrashedCopter.Show();
                panel_bottomwall.BackColor = Color.Sienna;
                MessageBox.Show("Game Over!!, Your Score:" + Score);
                HighScore = Score;
                saveHighScore();
                Application.Restart();
            }
            else if (pictureBox_Helicopter.Bounds.IntersectsWith(panel_bottomwall.Bounds))
            {
                HelicoptersoundPlayer.Stop();
                StartExplosionSound();
                timer_Clock.Stop();
                pictureBox_Helicopter.Hide();
                panel_bottomwall.Height = 65;
                pictureBox_CrashedCopter.Show();
                panel_bottomwall.BackColor = Color.Sienna;
                MessageBox.Show("Game Over!!, Your Score:" + Score);
                HighScore = Score;
                saveHighScore();
                Application.Restart();
            }
        }

        private void saveHighScore()
        {
            string file_Location = "C:\\Users\\muqee\\Desktop\\UMT\\Semesters\\Semester 6\\Scad (theory)\\Helicopter_Game_Assignment\\BestScore.txt";
            if (Score > ReadHighScore())
            {
                using (StreamWriter writer = new StreamWriter(file_Location, false))
                {
                    writer.WriteLine(Score);
                    writer.Close();
                }

            }
        }


        private int ReadHighScore()
        {
            string file_Location = "C:\\Users\\muqee\\Desktop\\UMT\\Semesters\\Semester 6\\Scad (theory)\\Helicopter_Game_Assignment\\BestScore.txt";
            string data = null;
            using (StreamReader reader = new StreamReader(file_Location))
            {
                data = reader.ReadLine();
                reader.Close();
            }
            return Convert.ToInt32(data);
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            label_BestScore.Show();
            label_Score.Show();
            panel_bottomwall.Show();
            panel_topwall.Show();
            panel_leftwall.Show();
            panel_rightwall.Show();
            pictureBox_Helicopter.Show();
            pictureBox_Hurdle.Show();
            button_start.Hide();
            spaceButtonHeldDown = false;
            LeftButtonHeldDown = false;
            this.BackgroundImage = null;
            timer_Clock.Start();
            startsoundPlayer.Stop();
            StartHelicoptorSound();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_Clock.Stop();
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are You Sure ?", "All Data Will Be Lost", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    timer_Clock.Start();
                }
            }
        }

        private void StartScreenSound()
        {
            string FilePath = "C:\\Users\\muqee\\Desktop\\UMT\\Semesters\\Semester 6\\Scad (theory)\\Helicopter_Game_Assignment\\Sounds\\startsound.wav";
            startsoundPlayer = new SoundPlayer(FilePath);
            startsoundPlayer.Play();
        }

        private void StartHelicoptorSound()
        {
            string FilePath = "C:\\Users\\muqee\\Desktop\\UMT\\Semesters\\Semester 6\\Scad (theory)\\Helicopter_Game_Assignment\\Sounds\\HelicopterSound.wav";
            HelicoptersoundPlayer = new SoundPlayer(FilePath);
            HelicoptersoundPlayer.Play();
        }
        
        private void StartExplosionSound()
        {
            string FilePath = "C:\\Users\\muqee\\Desktop\\UMT\\Semesters\\Semester 6\\Scad (theory)\\Helicopter_Game_Assignment\\Sounds\\ExplosionSound.wav";
            ExplosionsoundPlayer = new SoundPlayer(FilePath);
            ExplosionsoundPlayer.Play();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StartScreenSound();
        }
    }
}
