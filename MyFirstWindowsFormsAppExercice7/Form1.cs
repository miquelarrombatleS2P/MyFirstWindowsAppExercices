using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MyFirstWindowsFormsAppExercice7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Red");
            comboBox1.Items.Add("Yellow");
            comboBox1.Items.Add("Blue");
            comboBox1.Items.Add("Green");
            comboBox1.Items.Add("Black");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "The choosen clolour is " + comboBox1.SelectedItem;
        }
    }
}
