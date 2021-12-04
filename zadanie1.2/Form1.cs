using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание__1_Практика_граф_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                int num = Convert.ToInt32(textBox1.Text);
                int a = Convert.ToInt32(textBox2.Text);
                int sum = num % 10 + (num / 10) % 10;

                if ((sum % a) == 0)
                    textBox4.Text = Convert.ToString("число кратно");
                else
                    textBox4.Text = Convert.ToString("число не кратно");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}