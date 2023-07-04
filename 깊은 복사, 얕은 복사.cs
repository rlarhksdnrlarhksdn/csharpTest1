using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPAPP013
{
    class Myclass
    {
        public int Myfeild1;
        public int Myfeild2;

        //깊은 복사
        public Myclass DeepCopy()
        {
            Myclass newCopy = new Myclass();
            newCopy.Myfeild1 = this.Myfeild1;
            newCopy.Myfeild2 = this.Myfeild2;

            return newCopy;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass source = new Myclass();
            source.Myfeild1 = 10;
            source.Myfeild2 = 20;

            // 객체 생성? 일반적으로 new를 통해서 한다.
            //Myclass target = source;
            Myclass target = source.DeepCopy();

            target.Myfeild2 = 30;

            Console.WriteLine(source.Myfeild1 + " : " + source.Myfeild2); ;
            Console.WriteLine(source.Myfeild1 + " : " + target.Myfeild2);
        }
    }
}
