using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAPPTest005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("숫자를 입력해주세요 : ");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("1을 입력받았습니다.");
                        break;
                    case 2:
                        Console.WriteLine("2를 입력받았습니다.");
                        break;
                    default:
                        Console.WriteLine("1,2이외의 수를 받았습니다.");
                        break;
                }
                if (n == 100)
                        {
                            Console.WriteLine("100을 입력하여서 종료합니다.");
                            break;
                        }
            } while (true);
            }  
    }      
}

