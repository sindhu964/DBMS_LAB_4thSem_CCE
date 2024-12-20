using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registration_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("A");
            comboBox1.Items.Add("B");
            comboBox1.Items.Add("C");         
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            string course1 = "";
            string course2 = "";
            if (checkBox1.Checked == true)
            {
                course1 = checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                course2 = checkBox2.Text;
            }
            MessageBox.Show("Hello " + nameTextbox.Text + "\n\n Your Details are: \n Registration Number: " + RegNotextBox1.Text + "\n Branch: " + BranchtextBox2.Text + "\n Section: " + comboBox1.Text + "\n Courses Registering for: " + course1 + " " + course2);
            if(radioButton1.Checked == true && (checkBox1.Checked == true || checkBox2.Checked == true))
            {
                MessageBox.Show("Registration confirmed");
            }
            else if (radioButton2.Checked == true && (checkBox1.Checked == false || checkBox2.Checked == false))
            {
                MessageBox.Show("Registration failed");
            }
            else
            {
                MessageBox.Show("Registration failed");
            }
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegNotextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
