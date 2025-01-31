namespace crswrk_3
{
    partial class make_group
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
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            button4 = new Button();
            colorDialog1 = new ColorDialog();
            label7 = new Label();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(187, 456);
            button1.Name = "button1";
            button1.Size = new Size(268, 29);
            button1.TabIndex = 0;
            button1.Text = "Return to the tour information";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(57, 39);
            button2.Name = "button2";
            button2.Size = new Size(268, 29);
            button2.TabIndex = 1;
            button2.Text = "Show clients who have selected a tour";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 201);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(704, 39);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 4;
            label2.Text = "Selected: ...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 164);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 5;
            label3.Text = "Enter tour name";
            // 
            // button3
            // 
            button3.Location = new Point(364, 39);
            button3.Name = "button3";
            button3.Size = new Size(268, 29);
            button3.TabIndex = 6;
            button3.Text = "Add client to a group";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(392, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 27);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 164);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 9;
            label4.Text = "Enter client name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 270);
            label5.Name = "label5";
            label5.Size = new Size(208, 20);
            label5.TabIndex = 10;
            label5.Text = "Enter client's passport number";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(392, 311);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(193, 27);
            textBox4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(874, 460);
            label6.Name = "label6";
            label6.Size = new Size(18, 20);
            label6.TabIndex = 12;
            label6.Text = "...";
            // 
            // button4
            // 
            button4.Location = new Point(364, 100);
            button4.Name = "button4";
            button4.Size = new Size(268, 29);
            button4.TabIndex = 13;
            button4.Text = "Delete client from a group";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(974, 43);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 14;
            label7.Text = "Group: ...";
            // 
            // button5
            // 
            button5.Location = new Point(59, 100);
            button5.Name = "button5";
            button5.Size = new Size(266, 29);
            button5.TabIndex = 16;
            button5.Text = "Show a group";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 270);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 17;
            label1.Text = "...";
            // 
            // make_group
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 544);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "make_group";
            Text = "make_group";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Button button4;
        private ColorDialog colorDialog1;
        private Label label7;
        private Button button5;
        private Label label1;
    }
}