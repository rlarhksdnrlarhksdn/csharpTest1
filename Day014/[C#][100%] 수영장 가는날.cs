using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if(input == 1 || input == 3 || input == 5)
            {
                Console.WriteLine("enjoy");
            }
            else
            {
                Console.WriteLine("opps");
            }
        }
    }
}
