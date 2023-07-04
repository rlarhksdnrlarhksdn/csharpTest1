using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAPP00001
{
    //상속(완벽한 복사)
    class Car
    {
        public string name;
        protected int speed;
        private string brand;
        public void run()
        {
            Console.WriteLine("차가 달리다.");
        }
    }
    class Supercar : Car
    {
        public Supercar()
        {
            this.speed = 100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Supercar sc = new Supercar();
            sc.run();
            sc.name = "자동차";
        }
    }
}
