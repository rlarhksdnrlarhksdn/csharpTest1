using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Number = 0;
        DateTime NowTime;
        public void GetNumber()
        {
            Number ++;
        }
        public void OutNumber()
        {
            textBox1.AppendText(Number + "\r\n");
        }
        public void GetTime() 
        {
            NowTime = DateTime.Now;
        }
        public void OutTime()
        {
            textBox2.AppendText(NowTime + "\r\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 1;i< 5; i++)
            {
                GetNumber();
                OutNumber();
                GetTime();
                OutTime();
                System.Threading.Thread.Sleep(1000);
            }
            Environment.Exit(0);
        }
    }
}
