using System;

namespace Task_5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int m = 10;
            int[,] t = new int[n, m];
            int up = 0;
            int down = n - 1;
            int left = 0;
            int right = m - 1;
            int number = 0;
            while (number < m * n)
            {
                for (int i = left; i <= right; i++)
                {
                    t[up, i] = ++number;
                }
                up++;
                for (int i = up; i <= down; i++)
                {
                    t[i, right] = ++number;
                }
                right--;
                if (up <= down)
                {
                    for (int i = right; i >= left; i--)
                    {
                        t[down, i] = ++number;
                    }
                    down--;
                }
                if (left <= right)
                {
                    for (int i = down; i >= up; i--)
                    {
                        t[i, left] = ++number;
                    }
                    left++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,4} ", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}

