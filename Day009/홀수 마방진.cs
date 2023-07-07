using System;

class OddMagicSquare
{
    public static void Main(string[] args)
    {
        Console.Write("Enter an odd number: ");
        int n = int.Parse(Console.ReadLine());

        int[,] magicSquare = new int[n, n];
        int num = 1;
        int row = 0;
        int col = n / 2;

        while (num <= n * n)
        {
            magicSquare[row, col] = num;

            if (num % n == 0)
            {
                row++;
            }
            else
            {
                row--;
                col++;
                if (row < 0)
                    row = n - 1;
                if (col == n)
                    col = 0;
            }

            num++;
        }

        Console.WriteLine("Magic Square:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(magicSquare[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
