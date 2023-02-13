using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTask2
{
    public partial class Form2 : Form
    {
        double firstNum;
        string operation;
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_number_click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            label1.Text = null;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1);
            }
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(label1.Text);
            operation = "+";
            label1.Text = "";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(label1.Text);
            operation = "-";
            label1.Text = "";
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(label1.Text);
            operation = "*";
            label1.Text = "";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(label1.Text);
            operation = "/";
            label1.Text = "";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            double secondNum;
            double result;

            secondNum = Convert.ToDouble(label1.Text);

            if (operation == "+")
            {
                result = firstNum + secondNum;
                label1.Text = Convert.ToString(result);
                firstNum = result;
            }
            if (operation == "-")
            {
                result = firstNum - secondNum;
                label1.Text = Convert.ToString(result);
                firstNum = result;
            }
            if (operation == "*")
            {
                result = firstNum * secondNum;
                label1.Text = Convert.ToString(result);
                firstNum = result;
            }
            if(operation == "/")
            {
                result = firstNum / secondNum;
                label1.Text = Convert.ToString(result);
                firstNum = result;
            }
        }


    }
}
