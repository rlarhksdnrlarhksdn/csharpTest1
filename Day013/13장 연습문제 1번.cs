using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    delegate int MyDelegate(int a, int b);
    class Carculator
    {
        public int Plus(int a,int b)
        {
            return a + b;
        }

        public int Minus(int a , int b)
        {
            return a - b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Delegate Callback;

            Carculator calc = new Carculator();

            Callback = new MyDelegate(calc.Plus);

            Console.WriteLine(calc.Plus(3,4));

            Callback = new MyDelegate(calc.Minus);

            Console.WriteLine(calc.Minus(7,5));
        }
    }
}
