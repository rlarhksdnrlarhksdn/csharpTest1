using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_006
{
    class Carculator
    {
        public int Factorial(int a)
        {
            int result = 1;
            for(int i = 2; i <= a; i++)
            {
                result *=i;
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Carculator calculator = new Carculator();
            int cal = calculator.Factorial(num);
            Console.WriteLine(cal);

        }
    }
}
