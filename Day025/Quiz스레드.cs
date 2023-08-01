using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task myTask1 = Task.Run(() =>
            {
                int sum = 0;
                for (int i = 1; i < 101; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }); 

            myTask1.Wait(); 

            Task myTask2 = Task.Run(() => 
            {
                char Start = 'A';
                char End = 'Z';
                for (char c = Start; c <= End; c++)
                {
                    Console.Write(c + " ");
                }
            });

            myTask2.Wait();
        }
    }
}
