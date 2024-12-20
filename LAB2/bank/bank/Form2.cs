using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class Form2 : Form
    {
        public static int last_trans = 0;
        public static string last_trans_name = " ";
        public static string last_process = "";
        public Form2()
        {
            InitializeComponent();
            label7.Text = label7.Text + Form1.txt1;
            label8.Text = label8.Text + 78922000564;
            label9.Text = label9.Text + " NABK798826";
            label10.Text = label10.Text + Form1.balance;
            label12.Text = label12.Text + Form1.date;
            label14.Text = label14.Text + last_process + "\n \t";
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Available Balance is " + Form1.balance);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
