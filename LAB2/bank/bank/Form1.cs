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
    public partial class Form1 : Form
    {
        public static string txt1 = "";
        public static string txt2 = "";
        public static int balance = 10000;
        public static string pass = "abcd";
        public static string date = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sign_in_Click(object sender, EventArgs e)
        {
                date = DateTime.Now.ToString();
                if (textBox1.Text == "sindhu" && textBox2.Text != pass)
                {
                    MessageBox.Show("Incorrect Name or Password!");
                }
                else
                {
                    txt1 = textBox1.Text;
                    //txt2 = textbox2.Text;
                    Form2 f2 = new Form2();
                    this.Hide();
                    f2.ShowDialog();
                    this.Show();
                }
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
