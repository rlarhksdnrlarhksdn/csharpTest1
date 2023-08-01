using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N;
            string Grade;
            if (textBox1.Text == "")
            {
                MessageBox.Show("점수를 입력하세요!!");
                goto Nagayo;
            }
            N=int.Parse(textBox1.Text);
            if(100<N || N < 0)
            {
                MessageBox.Show("0과 100사이의 숫자를 입력하세요!!");
                goto Nagayo;
            }

            if (N >= 96)
            {
                Grade = "A+";
            }
            else if (N >= 91)
            {
                Grade = "A0";
            }
            else if (N >= 86)
            {
                Grade = "B+";
            }
            else if (N >= 81)
            {
                Grade = "B0";
            }
            else if (N >= 76)
            {
                Grade = "C+";
            }
            else if (N >= 71)
            {
                Grade = "C0";
            }
            else if (N >= 96)
            {
                Grade = "D+";
            }
            else if (N >= 96)
            {
                Grade = "D0";
            }
            else
            {
                Grade = "F:재수강";
            }
            textBox2.Text = Grade;
            Nagayo: textBox1.Focus();
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.TextLength;
        }
    }
}
