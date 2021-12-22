using System;

namespace Zadanie_6._3
{
    class Program
    {
        static void Main(string[] args)
        { 
            {
                int[,] arr = new int[3, 3] { { 22, 40, 0 }, { 63, 45, 17 }, { 1, 7, 2 }  };
                min(arr);
                count(arr);
                Console.ReadKey();


            }
            static void count(int[,] m)
            {
                int min = m[0, 0]; int value = 0;
                for (int i = 0; i < m.GetLength(0); i++)
                    for (int j = 0; j < m.GetLength(1); j++)
                    {

                        if (min > m[i, j])
                        { min = m[i, j]; }

                    }

                for (int i = 0; i < m.GetLength(0); i++)
                    for (int j = 0; j < m.GetLength(1); j++)
                    {
                        if (min == m[i, j])
                            value += 1;
                    }

            }

            static void min(int[,] m)
            {
                int sum = 0;
                int minsum = 0;
                int row = 0;
                for (int i = 0; i < m.GetLength(0); i++)
                {
                    for (int j = 0; j < m.GetLength(1); j++)
                    {
                        sum = 0;
                        sum += m[i, j];
                        if (i == 0)
                        {
                            minsum = sum;
                            row = i;
                        }

                    }
                    if (minsum < sum)
                    {
                        minsum = sum;
                        row = i;
                    }
                }
                Console.WriteLine("Норма равна: {0} ", minsum, row);
            }
        }
    }
}