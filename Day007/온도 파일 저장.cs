using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    interface ILogger
    {
        void WriteLog(string message);
    }
    class ConsoleLog // 방법 1
    {

    }
    class FileLogger : ILogger // 방법 2 
    {
        private StreamWriter writer;
        // 생성자
        public FileLogger(String path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WriteLog(string message)
        {
            writer.WriteLine(DateTime.Now.ToLocalTime() + " " + message);
        }
    }
    class ClimateMonitor // 대상 객체
    {
        private ILogger logger;

        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void Start()
        {
            while (true)
            {
                Console.Write("온도를 입력해주세요.");
                string temperature = Console.ReadLine();

                if (temperature == "")
                    break;

                logger.WriteLog("현재온도" + temperature);
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 객체가 콘솔로그 또는 파일로그 중 1개를 선택해서 로그만들기
            ClimateMonitor climateMonitor = new ClimateMonitor(new FileLogger("Mylog.txt"));

            climateMonitor.Start();
        }
    }
}

