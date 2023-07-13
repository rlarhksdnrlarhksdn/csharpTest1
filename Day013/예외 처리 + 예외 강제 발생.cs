using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Dosomething(int arg)
        {
            if (arg < 10)
                Console.WriteLine();
            else
                throw new Exception("arg가 10보다 큽니다.");
        }
        static void Main(string[] args)
        {
            try
            {
                Dosomething(1);
                Dosomething(11);
                Dosomething(13);
            }catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            
            }
        }
    }
}
