using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    //10진수 16진수 출력
    class Myclass
    {
        private delegate void RunDelegate(int a);

        private void RunThis(int val)
        {
            // 출력을 십진수 1024
            Console.WriteLine(val);
        }

        private void RunThat(int val)
        {
            // 출력을 16진수 400
            Console.WriteLine($"{val:X}");
        }
        public void Perform()
        {
            //1.delegate 객체를 생성
            RunDelegate run = new RunDelegate(RunThis);
            //2.10진수 출력
            run(1024);
            //3.16진수 출력
            //run = RunThat;
            run = new RunDelegate(RunThat);
            run(1024);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            myclass.Perform();
        }
    }
}
