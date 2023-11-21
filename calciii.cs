using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class calciii : Form
    {
        public calciii()
        {
            InitializeComponent();
        }
        string CalTotal;
        string[] num;
        decimal num1;
        decimal num2;
        string option;
        decimal result;
        private void button4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = decimal.Parse(txtTotal.Text);
            txtTotal.Text += "+";
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = decimal.Parse(txtTotal.Text);
            txtTotal.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = decimal.Parse(txtTotal.Text);
            txtTotal.Text += "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = decimal.Parse(txtTotal.Text);
            txtTotal.Text += "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //num2 = int.Parse(txtTotal.Text);
            if (option.Equals("+"))
            {
                string[] num = txtTotal.Text.Split('+');
                decimal num11 = decimal.Parse(num[0]);
                decimal num22 = decimal.Parse(num[1]);
                result = num11 + num22;
            }

            if (option.Equals("-"))
            {
                string[] num = txtTotal.Text.Split('-');
                decimal num11 = decimal.Parse(num[0]);
                decimal num22 = decimal.Parse(num[1]);
                result = num11 - num22;
            }
                
            if (option.Equals("*"))
            {
                string[] num = txtTotal.Text.Split('*');
                decimal num11 = decimal.Parse(num[0]);
                decimal num22 = decimal.Parse(num[1]);
                result = num11 * num22;
            }
            if (option.Equals("/"))
            {
                string[] num = txtTotal.Text.Split('/');
                decimal num11 = decimal.Parse(num[0]);
                decimal num22 = decimal.Parse(num[1]);
                result = num11 / num22;
            }
            txtTotal.Text = result + "";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            //result = (0);
            //num1 = (0);
            //num2=(0);
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            
            txtTotal.Text += ".";
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text.Substring(0, txtTotal.Text.Length - 1);

        }
        
    }
}
