using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302204032
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label2.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label2.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text += "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text += "8";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label2.Text += "0" ;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label2.Text += "+";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            label2.Text = "-";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label2.Text = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(label2.Text.Split('+')[0]);
            int num2 = Int32.Parse(label2.Text.Split('+')[1]);
            int result = num1 + num2;
            label2.Text = result.ToString();

            


        }
    }
}
