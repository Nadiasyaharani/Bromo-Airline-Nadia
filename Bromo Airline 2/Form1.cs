using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo_Airline_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "12345")
            {
                new Admin().Show();
                this.Hide();
            }
            else if (textBox1.Text == "User" && textBox2.Text == "678910")
            {
                new CustMain().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nama pengguna / kata sandi salah");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new DaftarAkun().Show();
            this.Hide();
        }
    }
}

