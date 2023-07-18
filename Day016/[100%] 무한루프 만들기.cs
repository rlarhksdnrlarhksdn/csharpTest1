using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace 과제_무한루프_만들기

{

    internal class Program

    {

        static void Main(string[] args)

        {

            while (true)

            {

                Console.Write("입력 : ");

                string input = Console.ReadLine();



                if (input == "q") 

                {

                    Console.WriteLine("프로그램이 종료되었습니다.");

                    break;

                }

            }

        }

    }

}

