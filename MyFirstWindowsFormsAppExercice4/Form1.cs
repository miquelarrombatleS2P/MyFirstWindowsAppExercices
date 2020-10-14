using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsFormsAppExercice4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox4.Text == "+")
            {
                int x = 0;
                x = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                textBox3.Text = x.ToString();
            }
            else
            {
                int x = 0;
                x = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                textBox3.Text = x.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "-";
        }
    }
}
