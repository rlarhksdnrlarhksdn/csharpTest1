using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LOOPAPP
{
    internal class Program
    {
        class Carculator
        {
            public int Powerofx(int a, int b)
            {
                int result = 0;

                for(int i = 0; i < b; i++)
                {
                    result *= a;
                }

                return result;
            }
        }

        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());

            int end = int.Parse(Console.ReadLine());

            Carculator cal = new Carculator();

            int result = cal.Powerofx(start,end);
            
            Console.WriteLine(result);
        }
    }
}
