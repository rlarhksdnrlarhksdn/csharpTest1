using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Enumerrator
{
    class MyEnumerrator
    {
        public int[] numbers = { 1, 2, 3, 4 };

        public IEnumerator GetEnumerator()
        {
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;
            yield return numbers[3]; // 동작하지 못하는 코드
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyEnumerrator();
            foreach(int i in obj)
                Console.WriteLine(i);
        }
    }
}
