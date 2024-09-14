using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Project_person_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this code to add icon from the file of the program .exe without need to add another icon
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
        }

        // this Function to Exit the Form
        private void Exite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Location or Position Of this Form

        private void setform()
        {
            this.Size = new Size(818, 485);
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            setform();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            setform();
        }

        // this Function to add a new Person
        private void AddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtName.Text.Trim() == "")
                {
                    MessageBox.Show("Plase Enter All Data and Try agine !");
                    return;
                }
                // Read All the file to the variable strcheck
                StreamReader srCheck = new StreamReader("Data.txt");
                string strcheck = srCheck.ReadToEnd();
                srCheck.Close();

                // check if the new ID is the same ID in side the file
                if (strcheck.Contains(txtID.Text + ";"))
                {
                    MessageBox.Show("Pleas Enter another ID");
                    txtID.Focus();
                    txtID.SelectAll(); // تضليل الرقم كامل
                }
                else
                {
                    StreamWriter sw = new StreamWriter("Data.txt", true);
                    string strPerson = txtID.Text + ";"
                                     + txtName.Text + ";"
                                     + txtAddress.Text;
                    sw.WriteLine(strPerson);
                    sw.Close();
                    MessageBox.Show("Person is Added");
                    // clean All the textBox 
                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                            c.Text = "";
                    }

                    txtID.Focus();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error agin latter");
            }

            
        }

        // this Function to Seartch on Person By ID
        private void Find_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() != "")
                {
                    StreamReader sr = new StreamReader("Data.txt");
                    string line = "";
                    bool found = false;

                    do
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            string[] arrData = line.Split(';');
                            if (arrData[0] == txtID.Text)
                            {
                                txtID.Text = arrData[0];
                                txtName.Text = arrData[1];
                                txtAddress.Text = arrData[2];
                                found = true;
                                break;
                            }
                        }



                    } while (line != null);
                    sr.Close();

                    if (!found)
                    {
                        MessageBox.Show("Sorry not found the person");
                        txtID.Focus();
                        txtID.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter ID And Try Agin !");
                    txtID.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // this Function to Show All the Person From the File
        private void ShowAll_Click(object sender, EventArgs e)
        {
            Form frmShow=new Form();
            TextBox textShow=new TextBox(); 
            frmShow.StartPosition = FormStartPosition.CenterScreen;
            frmShow.Font=this.Font;
            frmShow.Icon=this.Icon;
            frmShow.Size=this.Size;
            frmShow.Text = "All Data .";

            textShow.Multiline=true;
            textShow.Dock=DockStyle.Fill;
            textShow.ReadOnly=true;
            
            frmShow.Controls.Add(textShow);

            try
            {
                StreamReader sr = new StreamReader("Data.txt");
                string ReadAll =sr.ReadToEnd();
                sr.Close();

                textShow.Text = ReadAll;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            frmShow.ShowDialog();  
        }
    }
}
