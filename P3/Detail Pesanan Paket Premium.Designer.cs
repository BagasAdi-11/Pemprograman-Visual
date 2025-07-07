namespace gymkuuu
{
    partial class Form7
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            BtnLanjutPM = new Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(30, 31, 35);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(-5, -4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(952, 500);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DimGray;
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(BtnLanjutPM);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(203, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(547, 323);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(185, 221);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 7;
            label7.Text = "Rp 250.000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(189, 145);
            label6.Name = "label6";
            label6.Size = new Size(21, 20);
            label6.TabIndex = 6;
            label6.Text = "__";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(185, 64);
            label5.Name = "label5";
            label5.Size = new Size(271, 80);
            label5.TabIndex = 5;
            label5.Text = "- Durasi: 1 Bulan\r\n- Akses Gym Full (Senin - Minggu)\r\n- Free Konsultasi PT (1x)\r\n- Diskon 5% untuk pembelian suplemen\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(16, 65);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 4;
            label4.Text = "Basic Membersip      :";
            // 
            // BtnLanjutPM
            // 
            BtnLanjutPM.Location = new Point(256, 275);
            BtnLanjutPM.Name = "BtnLanjutPM";
            BtnLanjutPM.Size = new Size(271, 29);
            BtnLanjutPM.TabIndex = 3;
            BtnLanjutPM.Text = "Lanjutkan";
            BtnLanjutPM.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(175, 31);
            label1.TabIndex = 0;
            label1.Text = "Daftar Pesanan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(16, 221);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 2;
            label3.Text = "Subtotal                   :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(16, 148);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 1;
            label2.Text = "Pajak                         :";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 493);
            Controls.Add(groupBox1);
            Name = "Form7";
            Text = "Premium Membership";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button BtnLanjutPM;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}