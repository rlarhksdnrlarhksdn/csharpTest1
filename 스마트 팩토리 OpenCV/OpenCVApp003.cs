using OpenCvSharp;
using System;

namespace OpenCVApp003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Size size = new Size(640, 480);
            Mat img = new Mat(size, MatType.CV_8UC3);
            Mat img2 = new Mat(img.Size(), MatType.CV_8UC1);

            Console.WriteLine($"{size.Width}, {size.Height}");
            Console.WriteLine(img.Size());
            Console.WriteLine($"{img.Size().Width}, {img.Size().Height}");
            Console.WriteLine($"{img2.Width}, {img2.Height}");

            //Rect
            Rect rect1 = new Rect(new Point(0,0), new Size(640,480));
            Console.WriteLine(rect1);
            Rect rect2 = new Rect(100, 100, 640, 480);
            Console.WriteLine(rect2);
            Console.WriteLine();
            //RoraredRect
            RotatedRect rotatedRect = new RotatedRect(new Point2f(100f, 100f), new Size2f(100, 100), 45f);
            Console.WriteLine(rotatedRect.BoundingRect());
            Console.WriteLine(rotatedRect.Points().Length);
            Console.WriteLine(rotatedRect.Points()[0]);
        }
    }
}
