using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문제0001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[80];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);
            }



            // 처음 등장하는 숫자 '80'의 위치

            if (Array.IndexOf<int>(array, 80) >= 0)
            {
                Console.WriteLine($"80의 위치 : " + Array.IndexOf<int>(array, 80));

                Console.WriteLine();

                Array.Sort(array);

                Console.WriteLine($"정렬 후 80의 위치 : " + Array.IndexOf<int>(array, 80));
            }

            else
            {
                Console.WriteLine($"80의 위치 : " + Array.IndexOf<int>(array, 80));

                Console.WriteLine("값이 없습니다.");

                Environment.Exit(0);

            }


            //정렬 후 다시'80'의 위치 출력 만약 값이 없다면 "값이 없습니다." 메세지 출fur

        }
    }
}
