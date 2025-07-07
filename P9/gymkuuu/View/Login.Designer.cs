
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace gymkuuu
{
    partial class Form5
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
            groupBox2 = new GroupBox();
            label6 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            tpw = new TextBox();
            temail = new TextBox();
            label7 = new Label();
            button3 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(30, 31, 35);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.FromArgb(30, 31, 35);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(942, 491);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kristen ITC", 8F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.White;
            label5.Location = new Point(6, 47);
            label5.Name = "label5";
            label5.Size = new Size(266, 19);
            label5.TabIndex = 5;
            label5.Text = "Saatnya jadi versi terbaik dirimu!";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(30, 31, 35);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(110, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(723, 356);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(59, 138);
            label6.Name = "label6";
            label6.Size = new Size(214, 60);
            label6.TabIndex = 2;
            label6.Text = "Yuk, jelajahi berbagai info dan \r\nlayanan  seru  yang udah kami\r\nsiapin khusus buat kamu....\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(121, 83);
            label1.Name = "label1";
            label1.Size = new Size(91, 45);
            label1.TabIndex = 1;
            label1.Text = "HI !!";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(30, 31, 35);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(tpw);
            groupBox3.Controls.Add(temail);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(347, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(359, 333);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(149, 172);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 9;
            label9.Text = "Password :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(158, 112);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 8;
            label8.Text = "Email   :";
            // 
            // tpw
            // 
            tpw.Location = new Point(88, 195);
            tpw.Name = "tpw";
            tpw.Size = new Size(197, 27);
            tpw.TabIndex = 7;
            // 
            // temail
            // 
            temail.Location = new Point(88, 135);
            temail.Name = "temail";
            temail.Size = new Size(197, 27);
            temail.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(158, 286);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 3;
            label7.Text = "Sign Up";
            label7.Click += label7_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 46, 69);
            button3.ForeColor = Color.White;
            button3.Location = new Point(88, 243);
            button3.Name = "button3";
            button3.Size = new Size(197, 40);
            button3.TabIndex = 5;
            button3.Text = "Submit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kristen ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(119, 43);
            label4.Name = "label4";
            label4.Size = new Size(132, 45);
            label4.TabIndex = 2;
            label4.Text = "Sign In";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kristen ITC", 16F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 11);
            label3.Name = "label3";
            label3.Size = new Size(92, 36);
            label3.TabIndex = 3;
            label3.Text = "Kuuu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 16F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.FromArgb(255, 46, 69);
            label2.Location = new Point(5, 11);
            label2.Name = "label2";
            label2.Size = new Size(75, 36);
            label2.TabIndex = 2;
            label2.Text = "Gym";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 493);
            Controls.Add(groupBox1);
            Name = "Form5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string email = temail.Text.Trim();
            string password = tpw.Text.Trim();

            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE email = @email AND password = @pw";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@pw", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Login sukses, buka Form2
                                MessageBox.Show("Login berhasil!", "Sukses");
                                Form2 formBaru = new Form2();
                                formBaru.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Email atau Password salah!", "Login Gagal");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }

        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox3;
        private Label label4;
        private Button button3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private TextBox tpw;
        private TextBox temail;
    }
}