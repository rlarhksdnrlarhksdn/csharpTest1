using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_winApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iDigit1, iDigit2;
            iDigit1 = int.Parse(textBox1.Text);
            iDigit2 = int.Parse(textBox1.Text);
            textBox3.Text = (iDigit1 + iDigit2).ToString();
            label1.Text = " + ";
        }
    }
}
