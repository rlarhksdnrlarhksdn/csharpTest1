프로그램 명: powerofx
제한시간: 1 초
x 의 y 거듭제곱을 구하는 문제이다.

2 10 을 입력 받으면 2 의 10 거듭제곱 1024 가 출력되어야 한다.

2^10 = 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2=1024
입력
두 정수 x , y 가 입력된다.

출력
x 의 y 거듭제곱된 결과값을 출력한다.

출력 결과는 정수 범위( 2^31 - 1)를 넘지 않는다.

입출력 예
입력

2 10

출력

1024



using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LOOPAPP
{
    internal class Program
    {
        class Carculator
        {
            public int Powerofx(int a, int b)
            {
                int result = 0;

                for(int i = 0; i < b; i++)
                {
                    result *= a;
                }

                return result;
            }
        }

        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());

            int end = int.Parse(Console.ReadLine());

            Carculator cal = new Carculator();

            int result = cal.Powerofx(start,end);
            
            Console.WriteLine(result);
        }
    }
}
