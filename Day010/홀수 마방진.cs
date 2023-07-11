홀수 마방진을 만들어 봅시다.


 방진이란 가로, 세로 대각선의 합이 같은 사각형을 말한다. 홀수 n을

입력 받아 n*n 홀수 마방진을 구하고자 한다.

구현방법은

- 시작은 첫 행, 중간열에서 1을 두고

- 행을 감소, 열을 증가하면서 순차적으로 수를 넣어간다.

예외처리 두가지

- 행을 감소하므로 행이 첫 행보다 작아지는 경우는 행을 마지막 행으로 두고, 열은 증가하므로 열이 끝 열을 넘어가는 경우 열은 첫 열로 맞추어 준다.

- 테이블에 들어간 수가 n의 배수이면 행만 증가(열은 그대로)


 

N ? 3

8 1 6

3 5 7

4 9 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddMagicSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int N = int.Parse(Console.ReadLine());

            if (N % 2 == 0)
            {
                Console.WriteLine("N은 홀수만 가능합니다.");
                Environment.Exit(0);
            }

            int[,] magicSquare = new int[N, N]; //N이 입력된 상태라 크기가 결정됨
                                            //그리고 c#배열은 만들어지면 0으로 초기화 되어있다.
            int y = 0; //첫값의 y는 0
            int x = N / 2; //첫째줄 x값 정하기

            for (int i = 1; i <= N * N; i++) //N*N 마방진 크기
            {
                magicSquare[y, x] = i; // i는 채워넣는 카운트

                int tempX = (x + 1) % N; 
                int tempY = (y - 1 >= 0) ? y - 1 : N - 1; //조건이 참이면 y-1 아니면 N-1

                if (magicSquare[tempY, tempX] != 0) // 0이 아니라면 값을 넣을 수 없다.
                {
                    y = (y + 1) % N;
                }
                else
                {
                    x = tempX;  //tempX가 0인 상태라 값을 넣을 수 있다.
                    y = tempY;  
                }
            }//end of for --> 마방진 생성조건

            //마방진이 메모리엔 그려졌지만 이제 콘솔에서 그리기
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(magicSquare[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
