using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ConsoleApp2

{

    internal class Program

    {

        static void math(int N)

        {

            int sum = 0;

            for (int i = 1; i < N; i++)

            {

                if (N % i == 0)

                    sum += i;

            }

            if (sum == N)

                Console.WriteLine("Yes");

            else

                Console.WriteLine("No");

        }

        static void Main(string[] args)

        {

            int N;

            N=int.Parse(Console.ReadLine());

            math(N);

            

           

        }

    }

}

