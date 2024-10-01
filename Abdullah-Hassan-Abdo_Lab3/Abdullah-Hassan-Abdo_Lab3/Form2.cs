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
    public partial class sender : Form
    {
        public sender()
        {
            InitializeComponent();
        }

        // معرفة نوع الأداة التي تم الضغط عليها
        private void traingFormSender(object sender , EventArgs e)
        {
            // الطريقة الأولى لمعرفة الأداة التي تم الضغط عليها

            //if(sender == btnGreen)
            //{
            //    chColor.BackColor = Color.Green;
            //    MessageBox.Show("Clicked on Green");
            //}

            //else if (sender == btnRed)
            //{
            //    chColor.BackColor = Color.Red;
            //    MessageBox.Show("Clicked on Red");
            //}
            //else if(sender == btnYellow)
            //{
            //    chColor.BackColor = Color.Yellow;
            //    MessageBox.Show("Clicked on Yellow");
            //}
            
            // --------------------------------------------------------------------------

            // الطريقة الثانية لمعرفة الأداة التي تم الضغط عليها

            if(sender is Button)
            {
                Button clickedButton =(Button)sender;
                if(clickedButton == btnGreen)
                {
                    chColor.BackColor = Color.Green;
                }
                else if(clickedButton == btnRed)
                {
                    chColor.BackColor = Color.Red;
                }
                else if (clickedButton == btnYellow)
                {
                    chColor.BackColor = Color.Yellow;
                }

            }
            else if(sender is Label)
            {
                Label clickedLabel=(Label)sender;
                if(clickedLabel.Text == "جهاز 1")
                {
                    chColor.Text = label1.Text;
                }
                else if (clickedLabel.Text == "جهاز 2")
                {
                    chColor.Text = label2.Text;
                }
            }

        }
    }
}
