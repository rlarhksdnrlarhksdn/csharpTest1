using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                for (int j = N; j > i; j--)
                {
                    Console.Write(" ");
                }

                //Console.WriteLine();

                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
