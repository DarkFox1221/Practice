﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_6._1_Graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private static void main(string[] args)
        {
            int n, m;
            int[,] myArray = Input(out n, out m);
            Console.WriteLine("Исходный массив: ");
            Print(myArray);
            Console.WriteLine("Вывод: ");
            Change(myArray);
            Console.ReadKey();


        }

        private static void Change(int[,] a)
        {
            int res = 0;
            for (int i = 0; i < a.GetLength(0); ++i)
                for (int j = 0; j < a.GetLength(1); ++j)
                    if (a[i, j] % 2 == 0) res += a[i, j] * a[i, j];
            Console.WriteLine("Сумма квадратов четных элементов = {0}", res);
        }

        private static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0,5} ", a[i, j]);
            //Console.WriteLine();
        }

        private static int[,] Input(out int n, out int m)
        {
            Console.WriteLine("Введите размерность массива");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("a[{0},{1}] = ", i + 1, j + 1);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            return a;
        }

    }
}
        