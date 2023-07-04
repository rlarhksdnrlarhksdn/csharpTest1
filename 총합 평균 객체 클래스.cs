using CarculatorAPP003;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarculatorAPP003
{
    //사칙연산을 하는 계산기 만들기!
    class Carculator
    {
        //메소드
        public int executeTotalScore(int kor, int eng, int math)
        {
            return (kor + eng + math);
        }
        public int excuteAvg(int kor, int eng, int math)
        {
            return (kor + eng + math) / 3;
        }
       
        }
    }
    internal class Program
    {
        static void Main(string[] args)
    { 
        {
            Carculator cal = new Carculator();

            Console.Write("국어 : ");
            int kor = Int32.Parse(Console.ReadLine());
            Console.Write("영어 : ");
            int eng = Int32.Parse(Console.ReadLine());
            Console.Write("수학 : ");
            int math = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"총점 : {cal.executeTotalScore(kor, eng, math)}");
            Console.WriteLine($"평균 : {cal.excuteAvg(kor, eng, math)}");





        }
    }
}
