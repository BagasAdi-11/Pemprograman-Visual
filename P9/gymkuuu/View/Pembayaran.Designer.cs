namespace gymkuuu
{
    partial class Pembayaran
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
            groupBox2 = new GroupBox();
            label3 = new Label();
            label1 = new Label();
            label9 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label13 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(30, 31, 35);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(939, 488);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(338, 234);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(227, 58);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kristen ITC", 16F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(20, 15);
            label3.Name = "label3";
            label3.Size = new Size(190, 36);
            label3.TabIndex = 17;
            label3.Text = "221-30-20-232";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 16F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(356, 68);
            label1.Name = "label1";
            label1.Size = new Size(182, 36);
            label1.TabIndex = 15;
            label1.Text = "Pembayaran";
            label1.Click += label1_Click;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(172, 305);
            label4.Name = "label4";
            label4.Size = new Size(568, 40);
            label4.TabIndex = 19;
            label4.Text = "⏳ Batas waktu pembayaran: 23:59 WIB, 7 Juli 2025\r\n💡 Pastikan Anda membayar sesuai nominal agar proses verifikasi otomatis berhasil.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(172, 160);
            label5.Name = "label5";
            label5.Size = new Size(615, 80);
            label5.TabIndex = 20;
            label5.Text = "Silakan lakukan pembayaran ke Virtual Account berikut untuk menyelesaikan transaksi Anda:\n\nBank: BNI\nNomor Virtual Account:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 17F);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(877, 23);
            label13.Name = "label13";
            label13.Size = new Size(42, 40);
            label13.TabIndex = 19;
            label13.Text = "↩️";
            label13.Click += label13_Click;
            // 
            // Pembayaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 493);
            Controls.Add(groupBox1);
            Name = "Pembayaran";
            Text = "Payment";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label9;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Label label3;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label13;
    }
}