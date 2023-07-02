using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i += 2)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            for (int i = 2; i < arr.Length; i += 3)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
