using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApp03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 1. 예외
                /*int[] arrr = { 1, 2, 3 };

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arrr[i]);
                }*/
                // 2. 예외
                int a = 100;
                int result = a / 0;

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("배열 범위를 벗어난 예외 발생");
                Environment.Exit(1);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("0으로 나누면 안됩니다.");
                Environment.Exit(1);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(1);
            }

            Console.WriteLine("종료");
        }
    }
}
