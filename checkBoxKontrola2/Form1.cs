using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkBoxKontrola2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "Odabrali ste: " + "\r\n";
            textBox1.AppendText("\r\n");
            if(checkBox1.Checked == true)
            {

                textBox1.AppendText("Doručak " + "\r\n");

            }
            if (checkBox2.Checked == true)
            {

                textBox1.AppendText("Ručak " + "\r\n");

            }
            if (checkBox3.Checked == true)
            {

                textBox1.AppendText("Večera " + "\r\n");

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked == true)
            {
                textBox1.Visible = false;
            }
            if (checkBox4.Checked == false)
            {
                textBox1.Visible = true;
            }
        }
    }
}
