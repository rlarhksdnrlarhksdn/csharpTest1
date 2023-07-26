using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLamdaApp
{
    internal class Program
    {
        delegate int Calcurate(int a, int b);
        static void Main(string[] args)
        {
            Calcurate calc = (a, b) => a + b;
            Console.WriteLine(calc(3, 4));

        }
    }
}
