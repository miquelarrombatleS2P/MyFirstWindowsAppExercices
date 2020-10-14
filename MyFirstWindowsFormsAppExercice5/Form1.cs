using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsFormsAppExercice5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> resultado = new List<string>();

            //go through all the controls
            foreach (Control control in Controls)
            {
                // if any control is a CheckBox
                if (control is CheckBox)
                {
                    // review its value
                    CheckBox checkbox = control as CheckBox;
                    // if selected, you add it to a temporary list
                    if (checkbox.Checked)
                        resultado.Add(checkbox.Text);
                }
            }
            //concatenate to srings
            textBox1.Text = "Choosen animals: " + string.Join(", ", resultado.ToArray());
        }
    }
}
