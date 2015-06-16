using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft;
using System.Threading.Tasks;

namespace Clicky_Game
{
    public partial class Game : Form
    {
        Random random = new Random();
        public static System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
        public System.Media.SoundPlayer hitSound = new System.Media.SoundPlayer(resources.GetStream("hit"));
        public System.Media.SoundPlayer missSound = new System.Media.SoundPlayer(resources.GetStream("miss"));
        public Game()
        {
            InitializeComponent();
        }

        public double finalTime;
        public Boolean hovered = false;

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Z:
                    {
                        Console.WriteLine("You pressed z");
                        if (hovered == true)
                        {
                            Program.hits++;
                            hitSound.Play();

                            if ((Program.hits + Program.misses) == Program.targets)
                            {
                                Program.time = Program.watch.ElapsedMilliseconds;
                                Program.time += (1000 * Program.misses);
                                pictureBox1.Visible = false;
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = false;
                                button1.Visible = true;
                                button2.Visible = true;
                                label4.Visible = true;
                                label5.Visible = true;
                                label5.Text = "You hit " + Program.hits + " out of the " + Program.targets + " targets in " + Program.time + " milliseconds!";
                                Socketing.score = Program.time;
                                Socketing.sendScore();
                            }
                            Random random = new Random();
                            pictureBox1.Location = new System.Drawing.Point(random.Next((Screen.PrimaryScreen.Bounds.Width - 25)), random.Next((Screen.PrimaryScreen.Bounds.Height - 25)));
                            pictureBox3.Location = new System.Drawing.Point(random.Next((Screen.PrimaryScreen.Bounds.Width - 25)), random.Next((Screen.PrimaryScreen.Bounds.Height - 25)));
                            label1.Text = "Hits: " + Program.hits;
                            label3.Text = "Accuracy: " + Math.Round((100 * (Double)Program.hits / ((Double)Program.misses + (Double)Program.hits)), 2) + "%";
                        }
                        else
                        {
                            Program.misses++;
                            missSound.Play();
                            if ((Program.hits + Program.misses) == Program.targets)
                            {
                                Program.time = Program.watch.ElapsedMilliseconds;
                                Program.time += (1000 * Program.misses);
                                pictureBox1.Visible = false;
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = false;
                                button1.Visible = true;
                                button2.Visible = true;
                                label4.Visible = true;
                                label5.Visible = true;
                                label5.Text = "You hit " + Program.hits + " out of the " + Program.targets + " targets in " + Program.time + " milliseconds!";
                                Socketing.score = Program.time;
                                Socketing.sendScore();
                            }
                            Random random = new Random();
                            pictureBox1.Location = new System.Drawing.Point(random.Next((Screen.PrimaryScreen.Bounds.Width - 25)), random.Next((Screen.PrimaryScreen.Bounds.Height - 25)));
                            pictureBox3.Location = new System.Drawing.Point(random.Next((Screen.PrimaryScreen.Bounds.Width - 25)), random.Next((Screen.PrimaryScreen.Bounds.Height - 50)));
                            label2.Text = "Misses: " + Program.misses;
                            label3.Text = "Accuracy: " + Math.Round((100 * (Double)Program.hits / ((Double)Program.misses + (Double)Program.hits)), 2) + "%";
                        }
                        break;
                    }
                case Keys.X:
                    {
                        Console.WriteLine("You pressed z");
                        if (hovered == true)
                        {
                            Program.hits++;
                            hitSound.Play();

                            if ((Program.hits + Program.misses) == Program.targets)
                            {
                                Program.time = Program.watch.ElapsedMilliseconds;
                                Program.time += (1000 * Program.misses);
                                pictureBox1.Visible = false;
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = false;
                                button1.Visible = true;
                                button2.Visible = true;
                                label4.Visible = true;
                                label5.Visible = true;
                                label5.Text = "You hit " + Program.hits + " out of the " + Program.targets + " targets in " + Program.time + " milliseconds!";
                                Socketing.score = Program.time;
                                Socketing.sendScore();
                            }
                            Random random = new Random();
                            pictureBox1.Location = new System.Drawing.Point(random.Next((Screen.PrimaryScreen.Bounds.Width - 25)), random.Next((Screen.PrimaryScreen.Bounds.Height - 25)));
                            pictureBox3.Location = new System.Drawing.Point(random.Next((Screen.PrimaryScreen.Bounds.Width - 25)), random.Next((Screen.PrimaryScreen.Bounds.Height - 25)));
                            label1.Text = "Hits: " + Program.hits;
                            label3.Text = "Accuracy: " + Math.Round((100 * (Double)Program.hits / ((Double)Program.misses + (Double)Program.hits)), 2) + "%";
                        }
                        else
                        {
                            Program.misses++;
                            missSound.Play();
                            if ((Program.hits + Program.misses) == Program.targets)
                            {
                                Program.time = Program.watch.ElapsedMilliseconds;
                                Program.time += (1000 * Program.misses);
                                pictureBox1.Visible = false;
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = false;
                                button1.Visible = true;
                                button2.Visible = true;
                                label4.Visible = true;
                                label5.Visible = true;
                                label5.Text = "You hit " + Program.hits + " out of the " + Program.targets + " targets in " + Program.time + " milliseconds!";
                                Socketing.score = Program.time;
                                Socketing.sendScore();
                            }
                            Random random = new Random();
                            pictureBox1.Location = new System.Drawing.Point(random.Next((Screen.PrimaryScreen.Bounds.Width - 25)), random.Next((Screen.PrimaryScreen.Bounds.Height - 25)));
                            pictureBox3.Location = new System.Drawing.Point(random.Next((Screen.PrimaryScreen.Bounds.Width - 25)), random.Next((Screen.PrimaryScreen.Bounds.Height - 50)));
                            label2.Text = "Misses: " + Program.misses;
                            label3.Text = "Accuracy: " + Math.Round((100 * (Double)Program.hits / ((Double)Program.misses + (Double)Program.hits)), 2) + "%";
                        }
                        break;
                    }
            }
        }

        private void pictureBox1_Hover(Object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Size = new System.Drawing.Size(75, 75);
            hovered = true;
        }

        private void pictureBox1_Leave(Object sender, EventArgs e)
        {
            hovered = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Socketing.server.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
