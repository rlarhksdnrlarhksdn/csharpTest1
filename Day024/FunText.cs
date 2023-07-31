using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int> func = () => 10;
            Console.WriteLine($"func1() : {func()}");

            Func<double, double> func2 = (x) => x*3.14;
            Console.WriteLine(func2(10));

            Func<int, int, int> func3 = (x, y) => x + y;
            Console.WriteLine(func3(100, 200));

            Console.WriteLine();

            Action act1 = () => Console.WriteLine("Action()");
            act1();

            int result = 0;
            Action<int> act2 = (x) => result = x * x;
            act2(3);
            Console.WriteLine(result);
        }
    }
}
