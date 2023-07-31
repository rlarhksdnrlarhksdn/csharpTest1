using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, k;
            textBox1.Text = "";

            for (i = 2; i <= 9;i=i+4)
            {
                for (j = 1; j <= 9; j++)
                {
                    for (k = 0; k < 4; k++)
                    {
                        textBox1.Text = textBox1.Text + (i + k) + "X" + j + " = ";
                        textBox1.Text = textBox1.Text + ((i + k)*j) + "     ";
                    }
                    textBox1.Text = textBox1.Text + Environment.NewLine;
                }
                textBox1.Text = textBox1.Text + Environment.NewLine;
            }
        }
    }
}
