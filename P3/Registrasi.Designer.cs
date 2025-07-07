
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using MySql.Data.MySqlClient;
using System;

namespace gymkuuu
{
    partial class Form1
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
            GRBform1 = new GroupBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            tgllahir = new DateTimePicker();
            BtnClear = new Button();
            BtnAdd = new Button();
            BtnEdit = new Button();
            BtnMasuk = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tpw = new TextBox();
            temail = new TextBox();
            TxtNama = new TextBox();
            label1 = new Label();
            id = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            tanggalLahir = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            GRBform1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GRBform1
            // 
            GRBform1.BackColor = Color.FromArgb(30, 31, 35);
            GRBform1.Controls.Add(dataGridView1);
            GRBform1.Controls.Add(pictureBox1);
            GRBform1.Controls.Add(tgllahir);
            GRBform1.Controls.Add(BtnClear);
            GRBform1.Controls.Add(BtnAdd);
            GRBform1.Controls.Add(BtnEdit);
            GRBform1.Controls.Add(BtnMasuk);
            GRBform1.Controls.Add(label9);
            GRBform1.Controls.Add(label8);
            GRBform1.Controls.Add(label7);
            GRBform1.Controls.Add(label6);
            GRBform1.Controls.Add(label4);
            GRBform1.Controls.Add(label3);
            GRBform1.Controls.Add(label2);
            GRBform1.Controls.Add(tpw);
            GRBform1.Controls.Add(temail);
            GRBform1.Controls.Add(TxtNama);
            GRBform1.Controls.Add(label1);
            GRBform1.Location = new Point(2, 2);
            GRBform1.Name = "GRBform1";
            GRBform1.Size = new Size(936, 491);
            GRBform1.TabIndex = 0;
            GRBform1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nama, tanggalLahir, email, password });
            dataGridView1.Location = new Point(26, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(721, 188);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Bagas_Adi_Sasongko__1__removebg_preview;
            pictureBox1.Location = new Point(42, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // tgllahir
            // 
            tgllahir.CustomFormat = "yyyy-MM-dd";
            tgllahir.Format = DateTimePickerFormat.Custom;
            tgllahir.Location = new Point(354, 103);
            tgllahir.Name = "tgllahir";
            tgllahir.Size = new Size(393, 27);
            tgllahir.TabIndex = 18;
            tgllahir.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.FromArgb(255, 46, 69);
            BtnClear.ForeColor = SystemColors.ControlLightLight;
            BtnClear.Location = new Point(791, 173);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(94, 50);
            BtnClear.TabIndex = 16;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += button4_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.FromArgb(255, 46, 69);
            BtnAdd.ForeColor = SystemColors.ControlLightLight;
            BtnAdd.Location = new Point(791, 116);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(94, 50);
            BtnAdd.TabIndex = 15;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.FromArgb(255, 46, 69);
            BtnEdit.ForeColor = SystemColors.ControlLightLight;
            BtnEdit.Location = new Point(791, 59);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 50);
            BtnEdit.TabIndex = 14;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += button2_Click;
            // 
            // BtnMasuk
            // 
            BtnMasuk.BackColor = Color.FromArgb(255, 46, 69);
            BtnMasuk.ForeColor = SystemColors.ControlLightLight;
            BtnMasuk.Location = new Point(791, 436);
            BtnMasuk.Name = "BtnMasuk";
            BtnMasuk.Size = new Size(94, 29);
            BtnMasuk.TabIndex = 13;
            BtnMasuk.Text = "Masuk";
            BtnMasuk.UseVisualStyleBackColor = false;
            BtnMasuk.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Kristen ITC", 16.2F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(111, 48);
            label9.Name = "label9";
            label9.Size = new Size(98, 39);
            label9.TabIndex = 12;
            label9.Text = "Kuuu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Kristen ITC", 16.2F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.FromArgb(255, 46, 69);
            label8.Location = new Point(40, 48);
            label8.Name = "label8";
            label8.Size = new Size(78, 39);
            label8.TabIndex = 11;
            label8.Text = "Gym";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(238, 199);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 10;
            label7.Text = "Password       :";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(235, 154);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 9;
            label6.Text = "Email              :";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(235, 106);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 7;
            label4.Text = "Tanggal Lahir :";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(449, 235);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 6;
            label3.Text = "     ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(235, 64);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 5;
            label2.Text = "Nama             :";
            label2.Click += label2_Click;
            // 
            // tpw
            // 
            tpw.Location = new Point(354, 196);
            tpw.Name = "tpw";
            tpw.Size = new Size(393, 27);
            tpw.TabIndex = 4;
            tpw.TextChanged += textBox4_TextChanged;
            // 
            // temail
            // 
            temail.Location = new Point(354, 151);
            temail.Name = "temail";
            temail.Size = new Size(393, 27);
            temail.TabIndex = 3;
            temail.TextChanged += textBox3_TextChanged;
            // 
            // TxtNama
            // 
            TxtNama.Location = new Point(354, 60);
            TxtNama.Name = "TxtNama";
            TxtNama.Size = new Size(393, 27);
            TxtNama.TabIndex = 1;
            TxtNama.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(428, 140);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 125;
            // 
            // nama
            // 
            nama.DataPropertyName = "nama";
            nama.HeaderText = "Nama";
            nama.MinimumWidth = 6;
            nama.Name = "nama";
            nama.Width = 125;
            // 
            // tanggalLahir
            // 
            tanggalLahir.DataPropertyName = "tanggalLahir";
            tanggalLahir.HeaderText = "Tanggal Lahir";
            tanggalLahir.MinimumWidth = 6;
            tanggalLahir.Name = "tanggalLahir";
            tanggalLahir.Width = 125;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.Width = 125;
            // 
            // password
            // 
            password.DataPropertyName = "password";
            password.HeaderText = "Password";
            password.MinimumWidth = 6;
            password.Name = "password";
            password.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 493);
            Controls.Add(GRBform1);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Registrasi";
            GRBform1.ResumeLayout(false);
            GRBform1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 formBaru = new Form5();
            formBaru.Show();
            this.Hide();
        }

        private void LoadUsers()
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, nama, tanggal_lahir, email, password FROM users";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear(); // bersihkan data lama
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(
                                reader["id"],
                                reader["nama"],
                                Convert.ToDateTime(reader["tanggal_lahir"]).ToString("yyyy-MM-dd"),
                                reader["email"],
                                reader["password"]
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menampilkan data: " + ex.Message);
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Ambil data dari input
            string nama = TxtNama.Text.Trim();
            string tanggalLahir = tgllahir.Value.ToString("yyyy-MM-dd"); // pastikan ini DateTimePicker
            string email = temail.Text.Trim();
            string password = tpw.Text.Trim();

            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO users (nama, tanggal_lahir, email, password) " +
                                   "VALUES (@nama, @tgl, @email, @pw)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@tgl", tanggalLahir);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@pw", password);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data berhasil disimpan ke database!");

                    // ✅ Tampilkan data terbaru setelah insert
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }



        #endregion

        private GroupBox GRBform1;
        private TextBox textBox1;
        private Label label1;
        private TextBox tpw;
        private TextBox temail;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label9;
        private Button BtnClear;
        private Button BtnAdd;
        private Button BtnEdit;
        private Button button1;
        private PictureBox pictureBox1;
        private DateTimePicker tgllahir;
        private Button BtnMasuk;
        private TextBox TxtNama;
        private DataGridView dataGridView1;
        private string connStr;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn tanggalLahir;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn id;
    }
}
