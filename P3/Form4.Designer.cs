namespace gymkuuu
{
    partial class Form4
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
            label1 = new Label();
            label9 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(30, 31, 35);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(939, 488);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 16F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(358, 133);
            label1.Name = "label1";
            label1.Size = new Size(192, 36);
            label1.TabIndex = 15;
            label1.Text = "Virtual Bank";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Kristen ITC", 16.2F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(75, 11);
            label9.Name = "label9";
            label9.Size = new Size(98, 39);
            label9.TabIndex = 14;
            label9.Text = "Kuuu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 16F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.FromArgb(255, 46, 69);
            label2.Location = new Point(6, 11);
            label2.Name = "label2";
            label2.Size = new Size(75, 36);
            label2.TabIndex = 2;
            label2.Text = "Gym";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kristen ITC", 16F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(358, 233);
            label3.Name = "label3";
            label3.Size = new Size(190, 36);
            label3.TabIndex = 17;
            label3.Text = "221-30-20-232";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 493);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Payment";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label9;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Label label3;
    }
}