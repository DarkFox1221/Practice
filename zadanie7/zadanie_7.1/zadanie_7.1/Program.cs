using System;
using System.Collections.Generic; using System.Linq;
using System.Text;
using System.Text.RegularExpressions; using System.IO;

namespace Zadanie_7._1
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            int summ = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsNumber(s[i]))
                {

                    summ += Convert.ToInt32(s[i].ToString());
                    Console.WriteLine(summ);
                }
            }
        }
    }
    }