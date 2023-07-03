using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MetodTest001
{
    internal class Program
    {
        double Avg(int kor,int eng,int math)
        {
            int total = kor + eng + math;
            return total / 3.0;    
        }
        static void Main(string[] args)
        {
            int kor, eng, math;

            kor = int.Parse(Console.ReadLine());
            eng = int.Parse(Console.ReadLine());
            math = int.Parse(Console.ReadLine());

            Program p = new Program();
            double result=p.Avg(kor,eng,math);
            Console.WriteLine(result);


            /*int[] socore = new int[3];
            {
                for (int i = 0; i < 3; i++)
                {
                    socore[i] = int.Parse(Console.ReadLine());
                }
            }
            
            Program p = new Program();

            double result = p.Avg(socore[0], socore[1], socore[2]);
            
            Console.WriteLine(result);
            */
        }
    }
}
