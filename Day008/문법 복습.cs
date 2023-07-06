using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStudy02
{
    class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape 생성자가 호출됨");
        }
        public virtual void Draw()
        {
            Console.WriteLine("그리다.");
        }
        public virtual void Draw(string pen)
        {
            Console.WriteLine(pen + "그리다");
        }
        public virtual int Draw(string pen, int x)
        {
            Console.WriteLine(pen + "그리다" + "굵기는" + x);

            return x;
        }
    }
    class Triangle : Shape
    {
        // 1 ,멤버변수
        // 2. 생성자
        // 3. 멤버메소드
        public Triangle()
        {
            Console.WriteLine("Triangle 생성자가 호출됨");
        }

        public override void Draw()
        {
            base.Draw();
        }

        public override void Draw(string pen)
        {
            base.Draw(pen);
        }

        public override int Draw(string pen, int x)
        {
            return base.Draw(pen, x);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Triangle();
        }
    }
}
