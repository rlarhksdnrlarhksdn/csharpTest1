using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingThreadState
{
    internal class Program
    {
        private static void PrintTreadState(ThreadState state)
        {
            Console.WriteLine("{0,-16} : {1}", state, (int)state);
        }
        static void Main(string[] args)
        {
            PrintTreadState(ThreadState.Running);
            PrintTreadState(ThreadState.SuspendRequested);
            PrintTreadState(ThreadState.Background);
            PrintTreadState(ThreadState.Unstarted);
            PrintTreadState(ThreadState.Stopped);
            PrintTreadState(ThreadState.WaitSleepJoin);
            PrintTreadState(ThreadState.Suspended);
            PrintTreadState(ThreadState.AbortRequested);
            PrintTreadState(ThreadState.Aborted);
            PrintTreadState(ThreadState.Aborted | ThreadState.Stopped);
        }
    }
}
