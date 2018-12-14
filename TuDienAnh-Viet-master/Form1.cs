using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace test1
{
    public partial class Form1 : Form
    {
        //private int y1, y2, y3;
        private Random random;
        private int point=0;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && timer1.Enabled == true)
            {
                
                pictureBox1.Top -= 30;
                pictureBox1.Image = test1.Properties.Resources.up;
                //var stream = test1.Properties.Resources.ResourceManager.GetStream("tap.wav");
                //var soundPlayer = new System.Media.SoundPlayer(stream);
                SoundPlayer sound = new SoundPlayer(test1.Properties.Resources.tap);
                sound.Play();
            }
            if (e.KeyCode == Keys.Down && timer1.Enabled == true)
            {

                pictureBox1.Top += 20;
                pictureBox1.Image = test1.Properties.Resources.down;
                //var stream = test1.Properties.Resources.ResourceManager.GetStream("tap.wav");
                //var soundPlayer = new System.Media.SoundPlayer(stream);
                SoundPlayer sound = new SoundPlayer(test1.Properties.Resources.tap);
                sound.Play();
            }
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox1.Location = new Point(115, 162);
                pipe1.Location = new Point(359, 241);
                pipe2.Location = new Point(559, 241);
                pipe3.Location = new Point(759, 241);
                
                pipe4.Location = new Point(359, 0);
                pipe5.Location = new Point(559, 0);
                pipe6.Location = new Point(759, 0);

                pipe1.Height = 140;
                pipe2.Height = 140;
                pipe3.Height = 140;
                pipe4.Height = 141;
                pipe5.Height = 141;
                pipe6.Height = 141;
                this.Invalidate();
                point = 0;
                timer1.Enabled = true;
                timer2.Enabled = true;
               
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = test1.Properties.Resources.down;
            pictureBox1.Top += 20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            pipe1.Left -= 7;
            if (pipe1.Right <= 0)
            {
                pipe1.Height = random.Next(5, 20) * 10;
                this.Invalidate();
                pipe1.Location = new Point(510,225+(140-pipe1.Height));
                point++;
                SoundPlayer sound = new SoundPlayer(test1.Properties.Resources.pointup);
                sound.Play();
            }
            pipe2.Left -= 7;
            if (pipe2.Right <= 0)
            {
                pipe2.Height = random.Next(4, 20) * 10;
                this.Invalidate();
                pipe2.Location = new Point(510, 225 + (140 - pipe2.Height));
                point++;
                SoundPlayer sound = new SoundPlayer(test1.Properties.Resources.pointup);
                sound.Play();
            }
            pipe3.Left -= 7;
            if (pipe3.Right <= 0)
            {
                pipe3.Height = random.Next(5, 20) * 10;
                this.Invalidate();
                pipe3.Location = new Point(510, 225 + (140 - pipe3.Height));
                point++;
                SoundPlayer sound = new SoundPlayer(test1.Properties.Resources.pointup);
                sound.Play();
            }
            pipe4.Left -= 7;
            if (pipe4.Right <= 0)
            {
                pipe4.Height = 281 - pipe1.Height;
                this.Invalidate();
                pipe4.Location = new Point(510,0);
            }
            pipe5.Left -= 7;
            if (pipe5.Right <= 0)
            {
                pipe5.Height = 281 - pipe2.Height;
                this.Invalidate();
                pipe5.Location = new Point(510, 0);
            }
            pipe6.Left -= 7;
            if (pipe6.Right <= 0)
            {
                pipe6.Height = 281 - pipe3.Height;
                this.Invalidate();
                pipe6.Location = new Point(510, 0);
            }
            label1.Text = point.ToString();
            if(pipe1.Bounds.IntersectsWith(pictureBox1.Bounds) || pipe2.Bounds.IntersectsWith(pictureBox1.Bounds) || pipe3.Bounds.IntersectsWith(pictureBox1.Bounds) ||
                pipe4.Bounds.IntersectsWith(pictureBox1.Bounds) || pipe5.Bounds.IntersectsWith(pictureBox1.Bounds) || 
                pipe6.Bounds.IntersectsWith(pictureBox1.Bounds) || (pictureBox1.Top >320) || (pictureBox1.Top <1) )
            {
                SoundPlayer sound = new SoundPlayer(test1.Properties.Resources.gameover);
                sound.Play();
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("Game Over !\n Your Score: "+ point + "\n"+ "Press Enter to continue");
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
