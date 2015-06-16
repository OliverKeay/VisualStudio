using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicky_Game
{
    public partial class MainWindow : Form
    {
        Game form1 = new Game();
        HowToPlay how = new HowToPlay();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            form1.Show();
            Program.watch.Start();
        }

        private void fiveTargets_Click(object sender, EventArgs e)
        {
            Program.targets = 5;
            label1.Text = "Targets: " + Program.targets;
            StartPhoto.Visible = true;
        }

        private void tenTargets_Click(object sender, EventArgs e)
        {
            Program.targets = 10;
            label1.Text = "Targets: " + Program.targets;
            StartPhoto.Visible = true;
        }

        private void fifteenTargets_Click(object sender, EventArgs e)
        {
            Program.targets = 15;
            label1.Text = "Targets: " + Program.targets;
            StartPhoto.Visible = true;
        }

        private void twentyTargets_Click(object sender, EventArgs e)
        {
            Program.targets = 20;
            label1.Text = "Targets: " + Program.targets;
            StartPhoto.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            how.Show();
            this.Hide();
        }
    }
}
