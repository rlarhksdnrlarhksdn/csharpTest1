using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadInterrupt
{
    internal class Program
    {
        static void DoSomething()
        {
            try
            {
                for(int i=0; i<10000; i++)
                {
                    Console.WriteLine("DoSomething : {0}", i);
                    Thread.Sleep(10);
                }
            }catch(ThreadInterruptedException e)
            {
                Console.WriteLine("스레드 인터럭트 발생~~!!");
            }
            finally
            {
                Console.WriteLine("finally 동작 - 리소스 반환!!!");
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(DoSomething);
            t1.Start();
            t1.Interrupt();
            t1.Join();
        }
    }
}
