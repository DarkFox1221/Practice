using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_2._3_Practice_WF_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1, b = 20;
            while (a < b)
            {
                if (a % 2 == 0)
                    textBox1.Text = Convert.ToString(a + " ");
                a++;
            }

            do
            {
                if (a % 2 == 0)
                    textBox2.Text = Convert.ToString(a + " ");
                a++;
            }
            while (a < b);
            for (int i = a; i < b; i++)
            {
                if (i % 2 == 0)
                    textBox3.Text = Convert.ToString(i);
            }
        }
    }
}

