using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationApp01
{
    public partial class Form1 : Form
    {
        int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x+=5;
            pictureBox1.Location = new Point(x, y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = pictureBox1.Location.X;
            y = pictureBox1.Location.Y;
        }
    }
}
