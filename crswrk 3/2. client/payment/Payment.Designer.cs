﻿namespace crswrk_3
{
    partial class Payment
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
            label3 = new Label();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            label5 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(372, 25);
            button1.Name = "button1";
            button1.Size = new Size(233, 29);
            button1.TabIndex = 0;
            button1.Text = "Return to my personal account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(372, 87);
            button2.Name = "button2";
            button2.Size = new Size(233, 29);
            button2.TabIndex = 1;
            button2.Text = "Show my payment information";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(674, 29);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 7;
            label3.Text = "...";
            // 
            // button4
            // 
            button4.Location = new Point(372, 155);
            button4.Name = "button4";
            button4.Size = new Size(233, 29);
            button4.TabIndex = 9;
            button4.Text = "Add my payment to my cart";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(516, 301);
            button6.Name = "button6";
            button6.Size = new Size(221, 29);
            button6.TabIndex = 11;
            button6.Text = "Go to the payment page";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(257, 301);
            button7.Name = "button7";
            button7.Size = new Size(131, 29);
            button7.TabIndex = 12;
            button7.Text = "Clear my cart";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 34);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 13;
            label5.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(473, 245);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 17;
            label1.Text = "...";
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 606);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Payment";
            Text = "Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label3;
        private Button button4;
        private Button button6;
        private Button button7;
        private Label label5;
        private Label label1;
    }
}