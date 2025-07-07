namespace gymkuuu
{
    partial class Form3
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(30, 31, 35);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Crimson;
            groupBox1.Location = new Point(-5, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(946, 499);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kristen ITC", 34F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.White;
            label5.Location = new Point(213, 245);
            label5.Name = "label5";
            label5.Size = new Size(0, 79);
            label5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kristen ITC", 8F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.White;
            label4.Location = new Point(9, 53);
            label4.Name = "label4";
            label4.Size = new Size(266, 19);
            label4.TabIndex = 3;
            label4.Text = "Saatnya jadi versi terbaik dirimu!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kristen ITC", 16F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(73, 11);
            label3.Name = "label3";
            label3.Size = new Size(92, 36);
            label3.TabIndex = 2;
            label3.Text = "Kuuu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 16F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.FromArgb(255, 46, 69);
            label2.Location = new Point(4, 11);
            label2.Name = "label2";
            label2.Size = new Size(75, 36);
            label2.TabIndex = 1;
            label2.Text = "Gym";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 36F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(255, 46, 69);
            label1.Location = new Point(308, 215);
            label1.Name = "label1";
            label1.Size = new Size(305, 83);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            label1.Click += label1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 493);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Home";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
    }
}