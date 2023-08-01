using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public delegate void DataReceivedEventHandler(object sender, EventArgs e);
    public class DataReceiver
    {
        public event DataReceivedEventHandler DataReceived;
        public void OnDataReceived()
        {
            DataReceived?.Invoke(this, EventArgs.Empty);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            DataReceiver receiver = new DataReceiver();
            receiver.DataReceived += (sender, e) =>
                Console.WriteLine("데이터를 받았습니다.");

            receiver.OnDataReceived();  
        }
    }
}
