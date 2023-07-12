using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Mylist : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;

        public Mylist()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if(index>= array.Length)
                {
                    Array.Resize<int>(ref array, index +1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        // IEnumerable 멤버
        public object Current
        {
            get { return array[position]; }
        }
        //IEnumerator 멤버
        public bool MoveNext()
        {

            if(position == array.Length - 1)
            {
                Reset();
                return false;
            }

            position++;
            return (position < array.Length);
        }

        //IEnumerator 멤버
        public void Reset()
        {
            position = -1;
        }
        // IEnumerable 멤버
        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mylist mylist = new Mylist();
            for(int i = 0; i < 5; i++)
            {
                mylist[i] = i;
            }

            foreach (int e in mylist)
            {
                Console.WriteLine(e);
                Console.WriteLine($"List Currnt : "+mylist.Current);

                //mylist.Reset();
                //Console.WriteLine(mylist.MoveNext());
            }
                
        }
    }
}
