using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymkuuu.View
{
    public partial class Form8 : Form
    {
        public Form8() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLanjutPM_Click(object sender, EventArgs e)
        {
            Form2 formBaru = new Form2();
            formBaru.Show();
            this.Hide();
        }
    }
}
