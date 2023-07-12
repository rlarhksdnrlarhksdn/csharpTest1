ArrayWrapper 라는 클래스를 작성하세요 

이 클래스는 int 타입의 1차원 배열을 내부에 가지며, 

외부에서는 인덱서를 통해 해당 배열에 접근하거나 수정할 수 있어야 합니다. 


요구사항:

1. ArrayWrapper 클래스는 int[] 타입의 private 멤버 변수를 가져야 합니다.
2. ArrayWrapper 클래스는 주어진 길이를 가진 배열을 초기화하는 생성자를 가져야 합니다.
3. ArrayWrapper 클래스는 인덱서를 통해 배열의 특정 요소를 가져오거나 설정할 수 있어야 합니다.
4. ArrayWrapper 클래스는 배열의 모든 요소를 출력하는 Print 메소드를 가지고 있어야 합니다

-------------------------
0
10
20
30
40
 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace IndexerQuiz01
{
    class ArrayWrapper
    {
        //1. ArrayWrapper 클래스
        //int[] 타입의 private 멤버 변수를 가져야 합니다.
        private int[] array;

        public ArrayWrapper(int length) 
        {
            //2. ArrayWrapper 클래스
            //주어진 길이를 가진 배열을
            //초기화하는 생성자를 가져야 합니다.
            array = new int[length];       
        }

        //3. ArrayWrapper 클래스는 인덱서를 통해 배열의 특정 요소를 가져오거나
        //설정할 수 있어야 합니다.
        public int this[int index]
        {
            get 
            {
                return array[index];
            }
            set 
            { 
                array[index] = value;
            }
        }
        public void Print()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
    internal class Program
    {
        //4. ArrayWrapper 클래스는 배열의 모든 요소를 출력하는
        //Print 메소드를 가지고 있어야 합니다
        static void Main(string[] args)
        {
            ArrayWrapper arraywrapper = new ArrayWrapper(5);
            for(int i = 0; i < 5; i++)
            {
                arraywrapper[i] = i * 10;
            }
            arraywrapper.Print();
        }
    }
}
