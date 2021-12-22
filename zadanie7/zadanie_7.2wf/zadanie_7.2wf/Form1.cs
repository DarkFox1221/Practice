using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_7._2_Graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "Я хочу вечно цитировать сон";    
            string[] words = text.Split(',', '.', ' ', '!', '?', ';', '-', '/', '*');   
            string BiggestWord = words[0];     
            int BiggestLength = words[0].Length;     
            for (int i = 0; i < words.Length; i++)     
            {
                if (words[i] != "" && words[i].Length > BiggestLength)
                {
                    BiggestLength = words[i].Length;
                    BiggestWord = words[i];
                }
            }
            textBox1.Text = Convert.ToString(BiggestWord);
        }
    }
}


