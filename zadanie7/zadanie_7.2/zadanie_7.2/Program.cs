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
            Console.WriteLine("Введите сообщение");
            string[] vvod = Console.ReadLine().Split(' ', '.', ',', '!', '?');
            int max = 0;
            string slovo = "";
            for (int i = 0; i < vvod.GetLength(0); i++)
            {
                if (vvod[i].Length > max)
                {
                    max = vvod[i].Length;
                    slovo = vvod[i];
                }
            }
            Console.WriteLine("Самое длинное слово: {0}", slovo);

            Console.ReadKey();


        }
    }
}