using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Quiz040

{

    internal class Program

    {

        static void Main(string[] args)

        {

            int[] arr = {1,2,3,4};

            

            for (int i = 0; i < arr.Length; i++)

            {

                for (int j = 0; j < arr.Length; j++)

                {

                    if (i!=j && i<j)

                    {

                        Console.WriteLine(arr[i]+" "+ arr[j]);

                    }

                }

            }

        }

    }

}


