using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Zadanie_7._1_Graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "У Дани было 4 нервных срыва,еще 3 нервынх срыва он получил из-за проблем,сколько нервных срывов было у Дани?";

            int summ = 0;
            for (int i = 0; i < s.Length; i++)
                if (char.IsNumber(s[i]))
            {

                summ += Convert.ToInt32(s[i].ToString());


                string NewS = Regex.Replace(s, @"\w+я", "", RegexOptions.IgnoreCase);

                textBox1.Text = Convert.ToString(summ);
                Console.WriteLine(summ);
            }
        }
    }
}