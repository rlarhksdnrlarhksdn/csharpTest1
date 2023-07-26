using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWindow2
{
    internal class MainApp : Form
    {
        static void Main(string[] args)
        {
            MainApp form = new MainApp();

            form.Click += new EventHandler(
                (sender, eventArgs) =>
                {
                    Console.WriteLine("윈도우 닫기...");
                    Application.Exit();
                }
            );
            Console.WriteLine("윈도우 프로그램 시작...");
            Application.Run(form);

            Console.WriteLine("윈도우 프로그램 종료...");
        }
    }
}
