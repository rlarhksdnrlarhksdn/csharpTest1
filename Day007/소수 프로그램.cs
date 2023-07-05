using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test소수_구하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            for (a = 1; a < 100; a++)
            {
                b = 2;
                while (a > b)
                {
                    if (a % b == 0)     
                    {
                        break;
                    }
                    else                  
                    {
                        b++;
                    }
                }
                if (a == b)             
                {
                    Console.Write( a + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
