using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path1 = @"C:\Temp\dd.jpg";
            pictureBox1.Load(path1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path2 = @"C:\Temp\th.jpg";
            pictureBox1.Load(path2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path3 = @"C:\Temp\pic2.jpg";
            pictureBox1.Load(path3);
        }
    }
}
