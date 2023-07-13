using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예외_퀴즈01
{
    internal class Program
    {
        static void Method(int size)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("정상종료");

        }
        static void Main(string[] args)
        {
            Console.Write("입력 :");
            int a = int.Parse(Console.ReadLine()); // 예외 발생 시키기
            try
            {
                Method(a);
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("예외발생");
                Console.WriteLine("안전종료");
            }
        }
    }
}
