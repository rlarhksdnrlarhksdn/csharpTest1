using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dt = new DateTime(2023, 03, 04, 23, 18, 22);

            Console.WriteLine("12시간 형식 : {0:yyyy-MM-dd tt hh:mm:ss (ddd)}",dt);
            Console.WriteLine("12시간 형식 : {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

             CultureInfo ciko = new CultureInfo("ko-KR");
            Console.WriteLine();
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciko));
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciko));
            Console.WriteLine(ciko) ;

            CultureInfo ciEn = new CultureInfo("en-US");
            Console.WriteLine();
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));
            Console.WriteLine(ciEn);

            /*string name = "김튼튼";
            int age = 23;
            Console.WriteLine($"{name, -10},{age:D3}");

            name = "박날씨";
            age = 30;
            Console.WriteLine($"{name},{age,-10:D3}");
            
            name = "이비실";
            age = 17;
            Console.WriteLine($"{name},{(age > 20 ? "성인" : "미성년자")}");*/


        }
    }
}
