using System;
using System.Windows.Forms;

namespace MyFirstWindowsFormsAppExercice9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    comboBox1.Items.Add("Nº" + i);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    comboBox1.Items.Add("Nº" + i);
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
        }
    }
}
