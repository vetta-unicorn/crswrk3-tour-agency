﻿namespace crswrk_3
{ 
    partial class manager_log
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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(268, 52);
        button1.Name = "button1";
        button1.Size = new Size(196, 29);
        button1.TabIndex = 0;
        button1.Text = "Return to the main page";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(312, 341);
        button2.Name = "button2";
        button2.Size = new Size(94, 29);
        button2.TabIndex = 1;
        button2.Text = "Log in";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(204, 187);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(325, 27);
        textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(204, 281);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(325, 27);
        textBox2.TabIndex = 3;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(312, 138);
        label1.Name = "label1";
        label1.Size = new Size(111, 20);
        label1.TabIndex = 4;
        label1.Text = "Enter username";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(312, 245);
        label2.Name = "label2";
        label2.Size = new Size(110, 20);
        label2.TabIndex = 5;
        label2.Text = "Enter password";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(250, 408);
        label3.Name = "label3";
        label3.Size = new Size(109, 20);
        label3.TabIndex = 6;
        label3.Text = "Confirmation ...";
        // 
        // manager_log
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 520);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(button2);
        Controls.Add(button1);
        Name = "manager_log";
        Text = "manager_log";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}