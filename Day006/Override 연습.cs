using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAPP008
{
    // 도형 클래스를 만듭니다.
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("도형을 그립니다.");
        }
    }
    //삼각형 자식을 만들어주세요.
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("삼각형을 그립니다.");
        }
    }
    //사각형 자식
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("사각형을 그립니다.");
        }
    }
    // 원 자식
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("원을 그립니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            s1.Draw();
            Shape s2 = new Triangle();
            s2.Draw();
            Shape s3 = new Rectangle();
            s3.Draw();
            Shape s4 = new Circle(); 
            s4.Draw();

            Shape[] shapes = new Shape[4];
            shapes[0]= new Shape();
            shapes[1]= new Triangle();
            shapes[2]= new Rectangle();
            shapes[3]= new Circle();

            for(int i=0; i < 4; i++)
            {
                shapes[i].Draw();
            }
        }
    }
}
