using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace GymMemberApp
{
    public class MainForm : Form
    {
        private TextBox txtNama;
        private NumericUpDown numUmur;
        private ComboBox cmbKelamin;
        private Button btnTambah;
        private ListBox lstMember;
        private List<GymMember> daftarMember = new List<GymMember>();
        private SQLiteConnection conn;

        public MainForm()
        {
            this.Text = "Manajemen Member Gym";
            this.Width = 400;
            this.Height = 400;

            Label lblNama = new Label() { Text = "Nama", Top = 20, Left = 20 };
            txtNama = new TextBox() { Top = 40, Left = 20, Width = 200 };

            Label lblUmur = new Label() { Text = "Umur", Top = 80, Left = 20 };
            numUmur = new NumericUpDown() { Top = 100, Left = 20, Width = 100, Minimum = 10, Maximum = 100 };

            Label lblKelamin = new Label() { Text = "Jenis Kelamin", Top = 140, Left = 20 };
            cmbKelamin = new ComboBox() { Top = 160, Left = 20, Width = 150 };
            cmbKelamin.Items.AddRange(new string[] { "Laki-laki", "Perempuan" });
            cmbKelamin.SelectedIndex = 0;

            btnTambah = new Button() { Text = "Tambah Member", Top = 200, Left = 20 };
            btnTambah.Click += BtnTambah_Click;

            lstMember = new ListBox() { Top = 240, Left = 20, Width = 340, Height = 100 };
            lstMember.MouseDown += LstMember_MouseDown;

            this.Controls.Add(lblNama);
            this.Controls.Add(txtNama);
            this.Controls.Add(lblUmur);
            this.Controls.Add(numUmur);
            this.Controls.Add(lblKelamin);
            this.Controls.Add(cmbKelamin);
            this.Controls.Add(btnTambah);
            this.Controls.Add(lstMember);

            InitDatabase();
            LoadMembers();
        }

        private void InitDatabase()
        {
            if (!File.Exists("members.db"))
            {
                SQLiteConnection.CreateFile("members.db");
            }

            conn = new SQLiteConnection("Data Source=members.db;Version=3;");
            conn.Open();

            string sql = @"CREATE TABLE IF NOT EXISTS Members (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nama TEXT NOT NULL,
                            Umur INTEGER NOT NULL,
                            JenisKelamin TEXT NOT NULL
                        )";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();
        }

        private void LoadMembers()
        {
            lstMember.Items.Clear();
            daftarMember.Clear();

            string sql = "SELECT * FROM Members";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                GymMember member = new GymMember
                {
                    Nama = reader["Nama"].ToString(),
                    Umur = Convert.ToInt32(reader["Umur"]),
                    JenisKelamin = reader["JenisKelamin"].ToString()
                };
                daftarMember.Add(member);
                lstMember.Items.Add(member.ToString());
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GymMember member = new GymMember
            {
                Nama = txtNama.Text,
                Umur = (int)numUmur.Value,
                JenisKelamin = cmbKelamin.SelectedItem.ToString()
            };

            daftarMember.Add(member);

            string sql = "INSERT INTO Members (Nama, Umur, JenisKelamin) VALUES (@Nama, @Umur, @JenisKelamin)";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.Parameters.AddWithValue("@Nama", member.Nama);
            command.Parameters.AddWithValue("@Umur", member.Umur);
            command.Parameters.AddWithValue("@JenisKelamin", member.JenisKelamin);
            command.ExecuteNonQuery();

            LoadMembers(); // Refresh setelah tambah

            txtNama.Clear();
            numUmur.Value = 10;
            cmbKelamin.SelectedIndex = 0;
        }

        private void LstMember_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = lstMember.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    lstMember.SelectedIndex = index;
                    ContextMenu menu = new ContextMenu();
                    menu.MenuItems.Add("Hapus Member", (s, ev) => HapusMember(index));
                    menu.Show(lstMember, e.Location);
                }
            }
        }

        private void HapusMember(int index)
        {
            if (index >= 0 && index < daftarMember.Count)
            {
                GymMember member = daftarMember[index];

                string sql = "DELETE FROM Members WHERE Nama = @Nama AND Umur = @Umur AND JenisKelamin = @JenisKelamin";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.Parameters.AddWithValue("@Nama", member.Nama);
                command.Parameters.AddWithValue("@Umur", member.Umur);
                command.Parameters.AddWithValue("@JenisKelamin", member.JenisKelamin);
                command.ExecuteNonQuery();

                LoadMembers(); // Refresh setelah hapus
            }
        }
    }
}
