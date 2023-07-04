using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPAPPTest001
{
    class Carculator
    {
        //1. 정수 두개를 합산하는 Plus 메소드
        public int Plus(int x, int y)
        {
            return x + y;
        }
        //2. 정수 네개를 합산하는 Plus 메소드
        public int Plus(int x, int y, int z, int a)
        {
            return x + y + z + a;
        }
        //3. 더블 두개를 합산하는 Plus 메소드]
        public double Plus(double x, double y)
        {
            return x + y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Carculator carculator = new Carculator();

            Console.WriteLine(carculator.Plus(100, 200));
            Console.WriteLine(carculator.Plus(100, 200, 300, 400));
            Console.WriteLine(carculator.Plus(1.75, 2.77));

        }
    }
}
