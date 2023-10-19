[C#][OpenCV][Quiz] 이미지 파일을 읽어드리고 이를 그레이스케일로 변환 후 .jpg파일로 저장까지 해보자.
1. 이미지를 opencv를 이용해 메모리로 읽어 옵니다.
2. 그레이스케일로 변환합니다.
3. save.jpg로 저장합니다.﻿ 



using OpenCvSharp;
using System;
using System.Windows.Forms;

namespace OpenCVQuiz01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Path = "C:\\Temp\\img\\image.jpg";

            using(Mat image = new Mat(Path, ImreadModes.Color))
            {
                Bitmap bitmap = MatToBitmap(image);
                pictureBox1.Image = bitmap;
            }
        }

        private Bitmap MatToBitmap(Mat image)

        {

            using (var stream = new MemoryStream())

            {
                image.WriteToStream(stream);
                return new Bitmap(stream);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Path = "C:\\Temp\\img\\image.jpg";

            using (Mat image = new Mat(Path, ImreadModes.Color))
            {
                Mat gray = new Mat();
                Cv2.CvtColor(image, gray, ColorConversionCodes.BGR2GRAY);

                Bitmap bitmap = MatToBitmap(gray);
                pictureBox1.Image = bitmap;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string Path = "C:\\Temp\\img\\image.jpg";

            using (Mat image = new Mat(Path, ImreadModes.Color))
            {
                Bitmap bitmap = MatToBitmap(image);
                pictureBox1.Image = bitmap;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mat img = Cv2.ImRead("C:\\Temp\\img\\image.jpg");
            bool save;

            ImageEncodingParam[] prm = new ImageEncodingParam[]
            {
                new ImageEncodingParam(ImwriteFlags.JpegQuality,100),
                new ImageEncodingParam(ImwriteFlags.JpegProgressive,1)
        };
            save = Cv2.ImWrite("save.jpg", img, prm);
        }
    }
}
