using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic_project
{
    public partial class Form4 : Form
    {
        int x = 0;
        int y = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private int SizeNumber(string num)
        //{
        //    try
        //    {
        //        x = Convert.ToInt32(num);
        //    }
        //    
        //    return x;
        //}
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        // Function to show an Exception
        private void ShowError()
        {
            MessageBox.Show("قم بإدخال العدد أولا", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            textBox1.Text = null;
            textBox1.Focus();
        }

        // function for Summation
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(textBox1.Text);
                for (int i = 1; i <= x; i++)
                {
                    y += i;
                }
                label2.Text = y.ToString();
                y = 0;
            }
            catch (Exception)
            {
                ShowError();
            }

        }




            // Function for Factorial
            private void button2_Click(object sender, EventArgs e)
            {
                int fact = 1;
                try
                {
                    x = Convert.ToInt32(textBox1.Text);
                    for (int i = 1; i <= x; i++)
                    {
                       fact *= i;
                    }
                    label3.Text = fact.ToString();
                }
                catch (Exception)
                {
                   ShowError();
                }

            }

        // The square root of the number
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(textBox1.Text);
                double result = Math.Sqrt(number);

                label4.Text = result.ToString();
            }
            catch (Exception)
            {
                ShowError();
            }
           
        }
    }
}
