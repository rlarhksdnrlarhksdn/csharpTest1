using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAPP001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 문자열 "Hello" , "Halo" , "Hi"를 Queue에 입력하고 콘솔하면에 띄우시오.
            //Queue : 앞이 열려있고 뒤가 뚫여있는 구조  123 -> 123
            Queue<string> que = new Queue<string>();
            
            que.Enqueue("Hello");
            que.Enqueue("Halo");
            que.Enqueue("Hi");

            while(que.Count >0)
                Console.WriteLine(que.Dequeue());

            Console.WriteLine();

            // Stack 이랑 자료구조 Collection이 있다.
            // 입력을 Puch()로 하고 출력을  Pop()으로 하는 100 200 300을 입력해서
            // 300 200 100으로 출력하세요.
            
            Stack stack = new Stack();

            stack.Push(100);
            stack.Push(200);
            stack.Push(300);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
