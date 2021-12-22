using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[100];
            for (int i = 0; i < 100; i++)
                arr[i] = rand.Next(-50, 51);


            int min = arr.Min();
            int max = arr.Max();

            int min_index = Array.FindLastIndex(arr, delegate (int i)
            {
                return i == min;
            });
            int max_index = Array.FindIndex(arr, delegate (int i)
            {
                return i == max;
            });

            int sum = 0;

            if (max_index <= min_index)
            {
                for (int i = max_index + 1; i < min_index; i++)
                {
                    sum += arr[i];
                }
                Console.WriteLine("Сумма элементов: {0}", sum);
            }
            else
                Console.WriteLine("Максимальный результат расположен после минимального!");
            Console.ReadLine();
        }
    }
}