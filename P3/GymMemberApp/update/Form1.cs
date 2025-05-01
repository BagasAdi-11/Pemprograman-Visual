using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Registrasi : Form
    {
        string cnnString = "server=127.0.0.1;database=membergym;uid=root;pwd=;";
        MySqlConnection myConnection;

        public Registrasi()
        {
            InitializeComponent();
        }

        // Tombol Apply → Tampilkan data ke label
        private void button1_Click(object sender, EventArgs e)
        {
            DataDiriAnda.Text = $"{Lnama.Text}, \n{LtanggalLahir.Text}, \n{Lalamat.Text}, \n{Lpekerjaan.Text}";
        }

        // Tombol Clear → Bersihkan input
        private void btclear_Click(object sender, EventArgs e)
        {
            Lnama.Text = "";
            LtanggalLahir.Text = "";
            Lalamat.Text = "";
            Lpekerjaan.Text = "";
            DataDiriAnda.Text = "";
        }

        // Tombol database → Simpan ke tabel member
        private void database_Click(object sender, EventArgs e)
        {
            try
            {
                using (myConnection = new MySqlConnection(cnnString))
                {
                    myConnection.Open();

                    string query = "INSERT INTO member (nama_lengkap, tanggal_lahir, alamat, pekerjaan) " +
                                   "VALUES (@nama, @tanggal, @alamat, @pekerjaan)";

                    using (MySqlCommand cmd = new MySqlCommand(query, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@nama", Lnama.Text);

                        if (DateTime.TryParse(LtanggalLahir.Text, out DateTime tanggalLahir))
                        {
                            cmd.Parameters.AddWithValue("@tanggal", tanggalLahir.ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            MessageBox.Show("Format tanggal lahir tidak valid. Gunakan format: yyyy-MM-dd.");
                            return;
                        }

                        cmd.Parameters.AddWithValue("@alamat", Lalamat.Text);
                        cmd.Parameters.AddWithValue("@pekerjaan", Lpekerjaan.Text);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data berhasil disimpan ke tabel member.");
                        }
                        else
                        {
                            MessageBox.Show("Data gagal disimpan.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        // (Kosongkan event yang tidak dipakai supaya tidak bingung)
        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void Lpekerjaan_TextChanged(object sender, EventArgs e) { }
    }
}
