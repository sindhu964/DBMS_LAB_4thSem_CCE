namespace scientific_calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sub = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculate!!!";
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(229, 100);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(43, 23);
            this.Sub.TabIndex = 3;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Mul
            // 
            this.Mul.Location = new System.Drawing.Point(175, 143);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(48, 23);
            this.Mul.TabIndex = 4;
            this.Mul.Text = "x";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(229, 143);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(43, 23);
            this.Div.TabIndex = 5;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(175, 189);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(97, 23);
            this.equals.TabIndex = 6;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(113, 189);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(41, 23);
            this.clear.TabIndex = 7;
            this.clear.Text = "AC";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(113, 100);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(41, 23);
            this.three.TabIndex = 8;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 100);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(46, 23);
            this.one.TabIndex = 9;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(64, 100);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(43, 23);
            this.two.TabIndex = 10;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 130);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(46, 23);
            this.four.TabIndex = 11;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(64, 130);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(43, 23);
            this.five.TabIndex = 12;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(113, 129);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(41, 23);
            this.six.TabIndex = 13;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(13, 160);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(45, 23);
            this.seven.TabIndex = 14;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(64, 160);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(43, 23);
            this.eight.TabIndex = 15;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(113, 159);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(41, 23);
            this.nine.TabIndex = 16;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(12, 189);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(45, 23);
            this.zero.TabIndex = 17;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // dec
            // 
            this.dec.Location = new System.Drawing.Point(64, 189);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(43, 23);
            this.dec.TabIndex = 18;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.dec_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(175, 100);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(48, 23);
            this.add.TabIndex = 19;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.three);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button add;
    }
}

