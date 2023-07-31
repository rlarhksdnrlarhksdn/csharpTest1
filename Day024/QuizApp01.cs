using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, iSutja;
            Double dSum = 0;

            iSutja = int.Parse(textBox1.Text);

            textBox2.Text = "";

            for(i = 0; i <= iSutja; i++)
            {
                dSum = dSum+ i;
                textBox2.Text = textBox2.Text + i + " + ";
            }
            textBox2.Text = textBox2.Text + " = " + dSum;
        }
    }
}
