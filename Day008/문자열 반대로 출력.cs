using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1번 방법
            string t = Console.ReadLine();

            for (int i = t.Length-1; i >=0; i--)
            {
                Console.Write(t[i]);
            }

            Console.WriteLine();
            
            //2번 방법
            string input = Console.ReadLine();

            char[] array = input.ToCharArray();
            Array.Reverse(array);
            string reversed = new string(array);

            Console.WriteLine(reversed);

            //3번 방법
            string str = Console.ReadLine();

            Stack<char> stack = new Stack<char>(input);
            string reverse = string.Join("", array);
            Console.WriteLine(reverse);
        }
    }
}
