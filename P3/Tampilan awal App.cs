using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymkuuu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form5 formBaru = new Form5();  
            formBaru.Show();               
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public static implicit operator Form3(Form5 v)
        {
            throw new NotImplementedException();
        }
    }
}
