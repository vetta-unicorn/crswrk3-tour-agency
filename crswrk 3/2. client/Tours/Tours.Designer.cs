namespace crswrk_3
{
    partial class Tours
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
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            label3 = new Label();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(220, 55);
            button1.Name = "button1";
            button1.Size = new Size(284, 29);
            button1.TabIndex = 0;
            button1.Text = "Return to the personal account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(69, 201);
            button2.Name = "button2";
            button2.Size = new Size(165, 29);
            button2.TabIndex = 1;
            button2.Text = "Road movie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 110);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 2;
            label1.Text = "Available tours";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 151);
            label2.Name = "label2";
            label2.Size = new Size(278, 20);
            label2.TabIndex = 3;
            label2.Text = "Press the button to show the information";
            // 
            // button3
            // 
            button3.Location = new Point(320, 201);
            button3.Name = "button3";
            button3.Size = new Size(165, 29);
            button3.TabIndex = 4;
            button3.Text = "Winter wonderland";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(853, 176);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 5;
            label3.Text = "...";
            // 
            // button4
            // 
            button4.Location = new Point(558, 201);
            button4.Name = "button4";
            button4.Size = new Size(165, 29);
            button4.TabIndex = 6;
            button4.Text = "Ancient soul";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(53, 273);
            button5.Name = "button5";
            button5.Size = new Size(202, 54);
            button5.TabIndex = 7;
            button5.Text = "Tap to select \"Road movie\"";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(853, 110);
            label4.Name = "label4";
            label4.Size = new Size(189, 20);
            label4.TabIndex = 8;
            label4.Text = "Information about the tour:";
            // 
            // button6
            // 
            button6.Location = new Point(302, 273);
            button6.Name = "button6";
            button6.Size = new Size(202, 54);
            button6.TabIndex = 9;
            button6.Text = "Tap to select \"Winter wonderland\"";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(548, 273);
            button7.Name = "button7";
            button7.Size = new Size(202, 54);
            button7.TabIndex = 10;
            button7.Text = "Tap to slect \"Ancient soul\"";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(302, 440);
            button8.Name = "button8";
            button8.Size = new Size(211, 29);
            button8.TabIndex = 11;
            button8.Text = "Deselect all tours";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(383, 376);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 12;
            label5.Text = "...";
            // 
            // Tours
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 674);
            Controls.Add(label5);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Tours";
            Text = "Tours";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button3;
        private Label label3;
        private Button button4;
        private Button button5;
        private Label label4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label5;
    }
}