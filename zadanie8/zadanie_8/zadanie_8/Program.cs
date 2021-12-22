using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Zadanie_8._1
{


    class Program
    {
        static void Main(string[] args)
        {
            string str ="Номер Васи 32-42-23,Номер Пети  243-12-42,Номер Вовы 243-124-53" + "\n";

            char delim = ' ';
            string[] arr = str.Split(delim);

            Console.WriteLine(str);

            Regex[] patterns = {
               new Regex("(^\\d{3}-\\d{3}-\\d{2})"),
               new Regex("(^\\d{2}-\\d{2}-\\d{2})"),
            };

            for (int i = 0; i < arr.Length; i++)
            {
                foreach (var pat in patterns)
                {
                    if (pat.IsMatch(arr[i]))
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
