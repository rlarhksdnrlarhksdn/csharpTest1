using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen blackPen = new Pen(Color.Black, 3); // 생성자 확인
            Pen redPen = new Pen(Color.Red, 3);
            Pen bluePen = new Pen(Color.Blue, 4);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            // 그리기 함수들 사용
            Rectangle rectangle = new Rectangle(100, 100, 300, 300);
            g.DrawRectangle(blackPen, rectangle);
            
            //라인 그려봅시다.
            Point pt1 = new Point(100, 100);
            Point pt2 = new Point(400, 400);
           
            Point pt3 = new Point(400, 100);
            Point pt4 = new Point(100, 400);
            g.DrawLine(bluePen, pt1, pt2);
            g.DrawLine(bluePen, pt3, pt4);

            //삼각형 그리기
           

            Point point1 = new Point(100, 100);

            Point point2 = new Point(400, 100);

            Point point3 = new Point(250, 10);

            Point[] points = { point1, point2, point3 };

            g.DrawPolygon(bluePen, points);

            g.FillPolygon(redBrush, points);



            Rectangle rectf = new Rectangle(100, 100, 300, 300);

            g.DrawEllipse(bluePen, rectf);

            g.FillEllipse(blueBrush, rectf);
        }
    }
}
