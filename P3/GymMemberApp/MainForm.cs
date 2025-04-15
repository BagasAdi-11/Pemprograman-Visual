using System;
using System.Collections.Generic;
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

            this.Controls.Add(lblNama);
            this.Controls.Add(txtNama);
            this.Controls.Add(lblUmur);
            this.Controls.Add(numUmur);
            this.Controls.Add(lblKelamin);
            this.Controls.Add(cmbKelamin);
            this.Controls.Add(btnTambah);
            this.Controls.Add(lstMember);
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            GymMember member = new GymMember
            {
                Nama = txtNama.Text,
                Umur = (int)numUmur.Value,
                JenisKelamin = cmbKelamin.SelectedItem.ToString()
            };

            daftarMember.Add(member);
            lstMember.Items.Add(member.ToString());

            txtNama.Clear();
            numUmur.Value = 10;
            cmbKelamin.SelectedIndex = 0;
        }
    }
}