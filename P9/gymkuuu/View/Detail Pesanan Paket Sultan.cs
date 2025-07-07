using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gymkuuu.View;

namespace gymkuuu
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void BtnLanjutSM_Click(object sender, EventArgs e)
        {
            Pembayaran formBaru = new Pembayaran();
            formBaru.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Form2 formBaru = new Form2();
            formBaru.Show();
            this.Hide();
        }
    }
}
