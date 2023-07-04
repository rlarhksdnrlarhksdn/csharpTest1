using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace OOPAPP012
{
    class Cat
    {
        public Cat()//디폴트 생성자
        {
            Console.WriteLine("생성자가 호출되었습니다.");
        }
        ~Cat()
        {
            Console.WriteLine("객체의 소멸자가 호출되었습니다.");
        }
    }
    class RusianBlue : Cat
    {
        public RusianBlue()
        {
            Console.WriteLine("RussianBlue 생성자가 호출되었습니다.");
        }
        ~RusianBlue()
        {
            Console.WriteLine("RussianBlue 소멸자가 호출되었습니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cat cat = new Cat();
            RusianBlue rb = new RusianBlue();
        }
    }
}
