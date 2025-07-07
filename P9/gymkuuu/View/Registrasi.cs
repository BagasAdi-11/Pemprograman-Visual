using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace gymkuuu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Pilih baris yang ingin dihapus terlebih dahulu.");
            }
            else
            {
                // Ambil ID dari baris yang dipilih
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                object idObj = dataGridView1.Rows[selectedRowIndex].Cells[0].Value;

                if (idObj != null && int.TryParse(idObj.ToString(), out int id))
                {
                    DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        using (MySqlConnection conn = Koneksi.GetConnection())
                        {
                            try
                            {
                                conn.Open();
                                string query = "DELETE FROM users WHERE id = @id";
                                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@id", id);
                                    cmd.ExecuteNonQuery();
                                }

                                MessageBox.Show("Data berhasil dihapus!");
                                LoadUsers(); // Refresh isi tabel
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Gagal menghapus data: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ID tidak valid.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                TxtNama.Text = row.Cells[1].Value.ToString();
                tgllahir.Value = Convert.ToDateTime(row.Cells[2].Value);
                temail.Text = row.Cells[3].Value.ToString();
                tpw.Text = row.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Pilih baris dulu di tabel sebelum mengedit.");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

