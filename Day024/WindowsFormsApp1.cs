using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            Double dSum_Odd = 0, dSum_Even = 0;

            iSutja = int.Parse(textBox1.Text);

            textBox2.Text = "";
            textBox3.Text = "";

            for (i = 0; i <= iSutja; i++)
            {
                if(i%2 == 0)
                {
                    dSum_Even = dSum_Even + i;
                    if (textBox3.Text != "")
                        textBox3.Text = textBox3.Text + " + ";
                    textBox3.Text = textBox3.Text + i;
                }
                else
                {
                    dSum_Odd = dSum_Odd + i;
                    if (textBox2.Text != "")
                        textBox2.Text = textBox2.Text + " + ";
                    textBox2.Text = textBox2.Text + i;
                }
            }
            textBox2.Text = textBox2.Text + " = " + dSum_Odd;
            textBox3.Text = textBox3.Text + " = " + dSum_Even;
        }
    }
}
