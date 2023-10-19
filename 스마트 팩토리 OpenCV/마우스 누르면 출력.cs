using OpenCvSharp;
using System;

namespace cvKeyBoardTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Mat image = new Mat(200, 300, MatType.CV_8U, new Scalar(255)))
            {
                Cv2.NamedWindow("마우스 이벤트", WindowFlags.AutoSize);
                Cv2.ImShow("마우스 이벤트", image);

                Cv2.SetMouseCallback("마우스 이벤트", Event);

                Cv2.WaitKey(0);
            }
        }

        static void Event(MouseEventTypes @event, int x, int y, MouseEventFlags flags, IntPtr userdata)
        {
            if (@event == MouseEventTypes.LButtonDown)
                Console.WriteLine("마우스 왼쪽 버튼 누르기");
            else if (@event == MouseEventTypes.RButtonDown)
                Console.WriteLine("마우스 오른쪽 버튼 누르기");
            else if (@event == MouseEventTypes.RButtonUp)
                Console.WriteLine("마우스 오른쪽 버튼 떼기");
            else if (@event == MouseEventTypes.RButtonDoubleClick)
                Console.WriteLine("마우스 왼쪽 버튼 더블클릭");
        }
    }
}
