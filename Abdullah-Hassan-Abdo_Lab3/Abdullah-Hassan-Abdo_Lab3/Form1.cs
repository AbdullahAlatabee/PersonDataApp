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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            string operation1 = textoperation1.Text;
            string operation2 = textoperation2.Text;
            string intermediateResult = "";
            string finalResult = "";

            // التحقق من إدخال عملية حسابية صحيحة
            if (
                textoperation1.Text !="+" && 
                textoperation1.Text !="-" &&
                textoperation1.Text !="/" &&
                textoperation1.Text != "*"
               )
            {
                MessageBox.Show("عزيزي المستخدم قم بإدخال عملية حسابية صحيحة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textoperation1.Text = null;
                textoperation1.Focus();
                return;
            }
            // التحقق من إدخال عملية حسابية صحيحة
            if (
                textoperation2.Text != "+" &&
                textoperation2.Text != "-" &&
                textoperation2.Text != "/" &&
                textoperation2.Text != "*"
               )
            {
                textoperation2.Text = null;
                MessageBox.Show("عزيزي المستخدم قم بإدخال عملية حسابية صحيحة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textoperation2.Focus();
                return;
            }

            if (
                double.TryParse(textBox1.Text,out num1)&&
                double.TryParse(textBox3.Text, out num2)&&
                double.TryParse(textBox4.Text, out num3)
               )
            {
                // إجراء العملية حسب الأولوية
                if (textoperation1.Text == "/" || textoperation1.Text == "*")
                {
                    intermediateResult = PerformOperation(num1, num2, operation1).ToString();
                    finalResult = PerformOperation(Convert.ToDouble(intermediateResult), num3, operation2).ToString();

                }
                // إجراء العملية حسب الأولوية
                else if (textoperation2.Text == "/" || textoperation2.Text == "*")
                {
                    intermediateResult = PerformOperation(num2, num3, operation2).ToString();
                    finalResult = PerformOperation(num1,Convert.ToDouble(intermediateResult), operation1).ToString();

                }
                // إجراء العملية إذا لم تكن هناك أولوية
                else
                {
                    intermediateResult = PerformOperation(num1, num2, operation1).ToString();
                    finalResult = PerformOperation(Convert.ToDouble(intermediateResult), num3, operation2).ToString();
                }

                textResult.Text=finalResult.ToString();
            }
            else
            {
                MessageBox.Show("يرجى إدخال أرقام صحيحة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private double PerformOperation(double num1,double num2,string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                    case "-":
                    return num1 - num2;
                    case "*":
                    return num1 * num2;
                    case "/":
                    return num2 !=0 ? num1 / num2 : double.NaN;
                    default: 
                    return double.NaN;
            }
        }

     
    }
}
