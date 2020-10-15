using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsFormsAppExercice6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = "Choosen color: " +radioButton1.Text;
            } else if (radioButton2.Checked)
            {
                textBox1.Text = "Choosen color: " + radioButton2.Text;
            } else 
            {
                textBox1.Text = "Choosen color: " + radioButton3.Text;
            }
                
        }
    }
}
