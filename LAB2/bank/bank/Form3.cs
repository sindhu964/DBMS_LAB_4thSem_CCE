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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.Parse(amount.Text) < Form1.balance - 500)
            {
                Form2.last_trans_name = textBox1.Text;
                Form2.last_trans = int.Parse(amount.Text);
                Form2.last_process = " " + Form2.last_process + Form2.last_trans_name + " / Rs." + Form2.last_trans.ToString() + "\n \n                                 ";
                Form1.balance = Form1.balance - int.Parse(amount.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                amount.Text = "";
                MessageBox.Show("Rs." + amount.Text + " successfully transferred!! \n \n Avalaible balance: " + Form1.balance);
            }
            else
            {
                MessageBox.Show("Insufficient balance!");
            }
        }

        private void back3_Click(object sender, EventArgs e)
        {
            Form2 newf2 = new Form2();
            this.Hide();
            newf2.ShowDialog();


        }
    }
}
