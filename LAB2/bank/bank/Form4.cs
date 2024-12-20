using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pass1.Text == pass2.Text)
            {
                Form1.pass = pass1.Text;
                MessageBox.Show("Password Modified!!");
            }
            else
            {
                MessageBox.Show("Enter same password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pass1_TextChanged(object sender, EventArgs e)
        {
            pass1.PasswordChar = '*';
        }

        private void pass2_TextChanged(object sender, EventArgs e)
        {
            pass2.PasswordChar = '*';
        }
    }
}
