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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnBM_Click(object sender, EventArgs e)
        {
            Form8 formBaru = new Form8();
            formBaru.Show();
            this.Hide();
        }

        private void BtnPM_Click(object sender, EventArgs e)
        {
            Form7 formBaru = new Form7();
            formBaru.Show();
            this.Hide();
        }

        private void BtnSM_Click(object sender, EventArgs e)
        {
            Form6 formBaru = new Form6();
            formBaru.Show();
            this.Hide();
        }
    }
}
