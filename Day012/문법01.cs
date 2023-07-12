using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrenerocApp04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for(int i =0;i<5;i++)
                list.Add(i);

            foreach(int element in list)
                Console.Write(element+" ");

            Console.WriteLine();
            //list.Remove(4);
            list.RemoveAt(2);
            foreach (int element in list)
                Console.Write(element + " ");
            Console.WriteLine();

            list.Insert(2, 2); // 첫번째 인덱스 값, 두번째 넣을 값
            foreach (int element in list)
                Console.Write(element + " ");
        }
    }
}
