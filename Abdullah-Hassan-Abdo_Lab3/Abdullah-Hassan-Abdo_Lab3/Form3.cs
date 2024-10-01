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
    public partial class Form3 : Form
    {
        // Created by eng/ Abdullah Al-atabee
        double x,y,z;
       // string[] op = { "+", "-", "/", "*" };

        public Form3()
        {
            InitializeComponent();
            listBox1.Items.Add("+");
            listBox1.Items.Add("-");
            listBox1.Items.Add("*");
            listBox1.Items.Add("/");


            //listBox1.SelectedIndex = 0;
            // listBox1.Text = "+";
            //listBox1.Text = listBox1.Items[0];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            txtResult.ReadOnly = true;
           // combo.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = txtResult.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                x=Convert.ToDouble(textBox1.Text);
            }
            catch (Exception )
            {
                MessageBox.Show("العدد الأول غير صالح", "تحذير", MessageBoxButtons.OK,MessageBoxIcon.Hand);
                textBox1.Text = null;
                textBox1.Focus();
                return;
            }

            try
            {
                y = Convert.ToDouble(textBox2.Text);
            }
            catch (Exception )
            {
                MessageBox.Show("العدد الثاني غير صالح", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBox2.Text = null;
                textBox2.Focus();
                return;
            }
            bool f = true;

            switch (listBox1.SelectedIndex)
            {
                case 0:z = x + y;break;
                    case 1:z = x - y;break;
                case 2:z = x * y;break;
                case 3:
                    if (y != 0)
                    {
                        z = x / y;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("لا يمكن القسمة على صفر", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        f = false;
                        textBox2.Text=null;
                        textBox2.Focus();
                        txtResult.Text = null;
                       
                    }
                    break;
            }
            if (f==true && (listBox1.SelectedIndex == 0||
                            listBox1.SelectedIndex == 1||
                            listBox1.SelectedIndex == 2||
                            listBox1.SelectedIndex == 3
                           )
               )
            {
                txtResult.Text = z.ToString();
            }
            else
            {
                if (y != 0)
                {
                    MessageBox.Show("قم بإختيار عملية حسابية أولا", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                   
                }


            }


        }
    }
}
