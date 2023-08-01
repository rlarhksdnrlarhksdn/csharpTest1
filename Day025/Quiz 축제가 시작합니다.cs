using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public delegate void FestivalStartedEventHandler(object sender, EventArgs e);
    public class Festival
    {
        public event FestivalStartedEventHandler FestivalStarted;
        public void StartFestival()
        {
            FestivalStarted?.Invoke(this, EventArgs.Empty);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Festival festival = new Festival();

            festival.FestivalStarted += (sender, e) => Console.WriteLine("축제가 시작되었습니다.");
            festival.FestivalStarted += (sender, e) => Console.WriteLine("음악이 시작되었습니다.");

            festival.StartFestival();  // 이 메서드 호출을 통해 이벤트를 트리거하세요
        }
    }
}
