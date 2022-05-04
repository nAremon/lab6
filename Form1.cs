using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6LB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] numb = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string s = textBox1.Text;
            textBox2.Clear();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 48 & s[i] <= 57)
                {
                    textBox2.Text += s[i];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //случайно создал ;D
        }
    }
}
