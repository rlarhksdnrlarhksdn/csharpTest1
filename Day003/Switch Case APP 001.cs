using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseAPP001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("단을 입력하세요");

            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 3:
                    for(int i = 3; i<=3; i++)
                    {
                        for(int j=1; j <= 9; j++)
                        {
                            Console.WriteLine($"{i}*{j}={i*j}");
                        }
                    }
                    break;

                case 4:
                    for (int i = 4; i <= 4; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            Console.WriteLine($"{i}*{j}={i * j}");
                        }
                    }
                    break;

                case 5:
                    for (int i = 5; i <= 5; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            Console.WriteLine($"{i}*{j}={i * j}");
                        }
                    }
                    break;

                case 6:
                    for (int i = 6; i <= 6; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            Console.WriteLine($"{i}*{j}={i * j}");
                        }
                    }
                    break;

                default:
                    Console.WriteLine("기본값이 출력되었습니다.");
                    break;
            }
        }
    }
}
