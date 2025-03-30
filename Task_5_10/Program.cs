using System;

namespace Task_5_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 3;
            int[,] t = new int[n, n];
            Random rnd = new Random();
            bool rowWin = false;
            bool colomnWin = false;
            bool d1Win = true;
            bool d2Win = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    t[i, j] = rnd.Next(0, 2);
                    Console.Write("{0} ", t[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                rowWin = true;
                for (int j = 0; j < n; j++)
                {
                    if (t[i, j] != 1)
                    {
                        rowWin = false;
                        break;
                    }
                }
                if (rowWin)
                {
                    break;
                }
            }
            if (rowWin)
            {
                Console.WriteLine("Крестики выиграли в строке");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    colomnWin = true;
                    for (int j = 0; j < n; j++)
                    {
                        if (t[j, i] != 1)
                        {
                            colomnWin = false;
                            break;
                        }
                    }
                    if (colomnWin)
                    {
                        break;
                    }
                }
                if (colomnWin)
                {
                    Console.WriteLine("Крестики выиграли в столбце");
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {

                        if (t[i, i] != 1)
                        {
                            d1Win = false;
                            break;
                        }
                    }
                    if (d1Win)
                    {
                        Console.WriteLine("Крестики выиграли в основной диагонали");
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            if (t[i, n - i - 1] != 1)
                            {
                                d2Win = false;
                                break;
                            }
                        }
                    }
                    if (d2Win)
                    {
                        Console.WriteLine("Крестики выиграли в побочной диагонали");
                    }
                    else
                    {
                        Console.WriteLine("Крестики проиграли");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}