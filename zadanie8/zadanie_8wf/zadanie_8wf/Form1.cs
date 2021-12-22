using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Zadanie_8._1_Graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Номер Васи 32-42-23,Номер Пети  243-12-42,Номер Вовы 243-124-53" + "\n";

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
                        textBox2.Text = Convert.ToString(arr[i]);
                    }
                }

            }
        }
    }
}

