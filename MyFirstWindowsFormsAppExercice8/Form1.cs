using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsFormsAppExercice8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> classroom1 = new List<string>();
            classroom1.Add("Juan");
            classroom1.Add("Antonio");
            classroom1.Add("Maria");

            foreach (var alumno in classroom1)
            {
                listBox1.Items.Add(alumno);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> classroom2 = new List<string>();
            classroom2.Add("Miguel");
            classroom2.Add("Isabel");
            classroom2.Add("Sandra");

            foreach (var alumno in classroom2)
            {
                listBox1.Items.Add(alumno);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.GetItemText(listBox1.SelectedItem);
        }
    }
}
