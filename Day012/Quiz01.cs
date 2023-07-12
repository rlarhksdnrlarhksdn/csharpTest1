Main에서 문자열과 문자 각각 1개씩 입력받습니다. 

입력받은 문자열에 입력받은 문자가 몇개가 있는지 리턴하는 메소드를 구현해 주세요.



함수는 다음과 유사하게 만들어 주세요. 



public int CharCounter(char[] arr, char ch ) 





-----------------------------------

문자열 : HelloWorld

문자 : H

결과 : 1

------------------------------------

문자열 : HelloWorld

문자 : o

결과 : 2



using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ConsoleApp5

{



    internal class Program

    {

        static int CharCounter(char[] arr, char ch)

        {

            int N = 0;

            

            for(int i=0;i<arr.Length;i++)

            {

                if (arr[i] == ch)

                    N++;

            }



            return N;

        }

        static void Main(string[] args)

        {

            Console.Write("문자열 : ");

            string str = Console.ReadLine();

            Console.Write("문자 : ");

            string str2 = Console.ReadLine();

            char c = str2[0];



            char[] array = str.ToCharArray();

            int result = CharCounter(array,c);



            Console.Write("결과 : " + result);





        }

    }

}
