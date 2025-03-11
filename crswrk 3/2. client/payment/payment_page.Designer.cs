namespace crswrk_3
{
    partial class payment_page
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(257, 12);
            button1.Name = "button1";
            button1.Size = new Size(206, 29);
            button1.TabIndex = 0;
            button1.Text = "Return to the cart";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(698, 320);
            button2.Name = "button2";
            button2.Size = new Size(288, 29);
            button2.TabIndex = 1;
            button2.Text = "Pay";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(396, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(89, 320);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(464, 320);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(300, 404);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 167);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 7;
            label1.Text = "Enter the card number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 167);
            label2.Name = "label2";
            label2.Size = new Size(194, 20);
            label2.TabIndex = 8;
            label2.Text = "Enter the cardholder's name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 270);
            label3.Name = "label3";
            label3.Size = new Size(224, 20);
            label3.TabIndex = 9;
            label3.Text = "Enter the expiry month (number)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 270);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 10;
            label4.Text = "Enter the expity year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(300, 362);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 11;
            label5.Text = "Enter the CVC / CVV";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(352, 476);
            label6.Name = "label6";
            label6.Size = new Size(18, 20);
            label6.TabIndex = 12;
            label6.Text = "...";
            // 
            // button3
            // 
            button3.Location = new Point(698, 67);
            button3.Name = "button3";
            button3.Size = new Size(288, 29);
            button3.TabIndex = 13;
            button3.Text = "Show my payment information";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(257, 104);
            button4.Name = "button4";
            button4.Size = new Size(206, 29);
            button4.TabIndex = 14;
            button4.Text = "Add a card";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(734, 123);
            label7.Name = "label7";
            label7.Size = new Size(18, 20);
            label7.TabIndex = 15;
            label7.Text = "...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(734, 378);
            label8.Name = "label8";
            label8.Size = new Size(18, 20);
            label8.TabIndex = 16;
            label8.Text = "...";
            // 
            // payment_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 597);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "payment_page";
            Text = "payment_page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button3;
        private Button button4;
        private Label label7;
        private Label label8;
    }
}