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
    public partial class HowToPlay : Form
    {
        public HowToPlay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    {
                        Console.WriteLine("You pressed z");
                        break;
                    }
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    {
                        Console.WriteLine("You pressed z");
                        break;
                    }
            }
        }
    }
}
