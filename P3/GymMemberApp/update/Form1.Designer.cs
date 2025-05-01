namespace WinFormsApp1
{
    partial class Registrasi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nama = new Label();
            Lpekerjaan = new TextBox();
            label1 = new Label();
            alamat = new Label();
            LtanggalLahir = new TextBox();
            Lalamat = new TextBox();
            pekerjaan = new Label();
            tanggalLahir = new Label();
            Lnama = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btclear = new Button();
            label2 = new Label();
            btApply = new Button();
            groupBox2 = new GroupBox();
            label7 = new Label();
            DataDiriAnda = new Label();
            database = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Nama
            // 
            Nama.AutoSize = true;
            Nama.Location = new Point(13, 43);
            Nama.Name = "Nama";
            Nama.Size = new Size(182, 20);
            Nama.TabIndex = 0;
            Nama.Text = "Masukan Nama Lengkap  :";
            Nama.Click += label1_Click;
            // 
            // Lpekerjaan
            // 
            Lpekerjaan.Location = new Point(212, 177);
            Lpekerjaan.Name = "Lpekerjaan";
            Lpekerjaan.Size = new Size(327, 27);
            Lpekerjaan.TabIndex = 1;
            Lpekerjaan.TextChanged += Lpekerjaan_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 112);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            label1.Click += label1_Click_1;
            // 
            // alamat
            // 
            alamat.AutoSize = true;
            alamat.Location = new Point(13, 132);
            alamat.Name = "alamat";
            alamat.Size = new Size(180, 20);
            alamat.TabIndex = 3;
            alamat.Text = "Alamat                              :";
            // 
            // LtanggalLahir
            // 
            LtanggalLahir.Location = new Point(212, 87);
            LtanggalLahir.Name = "LtanggalLahir";
            LtanggalLahir.Size = new Size(327, 27);
            LtanggalLahir.TabIndex = 4;
            // 
            // Lalamat
            // 
            Lalamat.Location = new Point(212, 132);
            Lalamat.Name = "Lalamat";
            Lalamat.Size = new Size(327, 27);
            Lalamat.TabIndex = 5;
            // 
            // pekerjaan
            // 
            pekerjaan.AutoSize = true;
            pekerjaan.Location = new Point(13, 177);
            pekerjaan.Name = "pekerjaan";
            pekerjaan.Size = new Size(179, 20);
            pekerjaan.TabIndex = 6;
            pekerjaan.Text = "Pekerjaan                          :";
            pekerjaan.Click += label3_Click;
            // 
            // tanggalLahir
            // 
            tanggalLahir.AutoSize = true;
            tanggalLahir.Location = new Point(13, 87);
            tanggalLahir.Name = "tanggalLahir";
            tanggalLahir.Size = new Size(180, 20);
            tanggalLahir.TabIndex = 7;
            tanggalLahir.Text = "Tanggal Lahir                    :";
            // 
            // Lnama
            // 
            Lnama.Location = new Point(212, 40);
            Lnama.Name = "Lnama";
            Lnama.Size = new Size(327, 27);
            Lnama.TabIndex = 8;
            Lnama.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(326, 323);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btclear);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btApply);
            groupBox1.Controls.Add(Nama);
            groupBox1.Controls.Add(Lnama);
            groupBox1.Controls.Add(pekerjaan);
            groupBox1.Controls.Add(Lpekerjaan);
            groupBox1.Controls.Add(tanggalLahir);
            groupBox1.Controls.Add(Lalamat);
            groupBox1.Controls.Add(LtanggalLahir);
            groupBox1.Controls.Add(alamat);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 248);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // btclear
            // 
            btclear.Location = new Point(587, 140);
            btclear.Name = "btclear";
            btclear.Size = new Size(155, 64);
            btclear.TabIndex = 12;
            btclear.Text = "Clear";
            btclear.UseVisualStyleBackColor = true;
            btclear.Click += btclear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 11;
            label2.Click += label2_Click;
            // 
            // btApply
            // 
            btApply.Location = new Point(587, 40);
            btApply.Name = "btApply";
            btApply.Size = new Size(155, 67);
            btApply.TabIndex = 9;
            btApply.Text = "Apply";
            btApply.UseVisualStyleBackColor = true;
            btApply.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(database);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(DataDiriAnda);
            groupBox2.Location = new Point(12, 266);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 172);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(324, 76);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 1;
            // 
            // DataDiriAnda
            // 
            DataDiriAnda.AutoSize = true;
            DataDiriAnda.Font = new Font("Segoe UI", 12F);
            DataDiriAnda.Location = new Point(13, 23);
            DataDiriAnda.Name = "DataDiriAnda";
            DataDiriAnda.Size = new Size(140, 28);
            DataDiriAnda.TabIndex = 0;
            DataDiriAnda.Text = "Data Diri Anda";
            DataDiriAnda.Click += label6_Click;
            // 
            // database
            // 
            database.Location = new Point(587, 126);
            database.Name = "database";
            database.Size = new Size(171, 40);
            database.TabIndex = 12;
            database.Text = "Masukkan Ke Database";
            database.UseVisualStyleBackColor = true;
            database.Click += database_Click;
            // 
            // Registrasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Registrasi";
            Text = "Regristasi Member Gym";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nama;
        private TextBox Lpekerjaan;
        private Label label1;
        private Label alamat;
        private TextBox LtanggalLahir;
        private TextBox Lalamat;
        private Label pekerjaan;
        private Label tanggalLahir;
        private TextBox Lnama;
        private Label label5;
        private GroupBox groupBox1;
        private Button btApply;
        private GroupBox groupBox2;
        private Label DataDiriAnda;
        private Label label7;
        private Button button2;
        private Label label2;
        private Button btclear;
        private Button database;
    }
}
