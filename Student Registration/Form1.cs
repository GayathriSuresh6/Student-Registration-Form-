using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void phonoValidation(object sender,EventArgs e)
        {
            if (Phno.Text == string.Empty)
                {
                    MessageBox.Show("Please enter phone number", "ERROR");
              
                }
            Regex phregex = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            bool isValid = phregex.IsMatch(Phno.Text.Trim());
            if (!isValid)
            {
                error.Text = "Invalid phone number";
            }
            else
            {
                error.Text = " ";
            
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nameValidation(object sender, EventArgs e)
        {
            
            if (nametxt.Text == String.Empty)
            {
                MessageBox.Show("Please enter name", "ERROR");
            }

            Regex regex_name = new Regex("^[a-zA-Z\\s]*$");
            bool isValid = regex_name.IsMatch(nametxt.Text.Trim());
            if (!isValid)
            {
                error.Text = "Invalid Name";
               
            }
            else
            {
                error.Text = " ";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void regValidation(object sender, EventArgs e)
        {

            if (reg.Text == String.Empty)
            {
                MessageBox.Show("Please enter register number", "ERROR");
            }

            Regex regexreg = new Regex("^[0-9]{7}$");
            bool isValid = regexreg.IsMatch(reg.Text.Trim());
            if (!isValid)
            {
                error.Text = "Invalid Register Number";
            }
            else
            {
                error.Text = " ";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailValidation(object sender, EventArgs e)
        {
            if (email.Text == String.Empty)
            {
                MessageBox.Show("Please enter Email ID", "ERROR");
            }

            Regex regexemail = new Regex(@"^\w*@[a-zA-Z]*.[a-z]{2,3}$");
            bool isValid = regexemail.IsMatch(email.Text.Trim());
           
            if (!isValid)
            {
                error.Text = "Invalid Email";
            }
            else
            {
                error.Text = " ";
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (error.Text == " ")
            {
                MessageBox.Show("Registeration Succesful");

                nametxt.Text = "";
                reg.Text = "";
                Phno.Text = "";
                email.Text = "";

            }
            else
            {
                MessageBox.Show("ERROR!");
            }
        }

        private void admission_Click(object sender, EventArgs e)
        {
            Form2 admissionfrom = new Form2();
            admissionfrom.ShowDialog(); 
        }

        private void classt_Click(object sender, EventArgs e)
        {
            Form3 classtfrom = new Form3();
            classtfrom.ShowDialog();
        }

        private void lib_Click(object sender, EventArgs e)
        {
            Form4 Libfrom = new Form4();
            Libfrom.ShowDialog();
        }

        private void coe_Click(object sender, EventArgs e)
        {
            Form5 coefrom = new Form5();
            coefrom.ShowDialog();
        }

        private void cam_Click(object sender, EventArgs e)
        {
            Form6 camfrom = new Form6();
            camfrom.ShowDialog();
        }
    }
}
