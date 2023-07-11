입력
n 은 3 이상 20 이하의 정수이다.

출력
내각의 합, 외각의 합을 출력한다.

입출력 예
입력

3

출력

180 360

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write($"내각의 합 : {180 * (n - 2)}");

            Console.WriteLine();

            Console.Write($"외각의 합 : {(180 - ((180 * (n - 2)) / n)) * n}");
        }
    }
}
