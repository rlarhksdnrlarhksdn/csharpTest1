using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat nero = new Cat();
            nero.Name = "네로";
            nero.Age = 10;
            nero.Color = "검은색";
            Console.WriteLine($"이름:{nero.Name},나이:{nero.Age}, 색깔:{nero.Color} ");
        }
    }
}
