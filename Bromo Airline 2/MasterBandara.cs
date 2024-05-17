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
    public partial class MasterBandara : Form
    {
        public MasterBandara()
        {
            InitializeComponent();
        }

        private void MasterBandara_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Abdul Rachman Saleh", "MLG", "Malang", "Indonesia", "2", "Malang");
            dataGridView1.Rows.Add("Abresso", "RSK", "Monokwari", "Indonesia", "2", "Monokwari");
            dataGridView1.Rows.Add("Achmad Yani", "SRG", "Semarang", "Indonesia", "2", "Semarang");
            dataGridView1.Rows.Add("Adi Sucipto", "JOG", "Yogyakarta", "Indonesia", "2", "Yogyakarta");
            dataGridView1.Rows.Add("Adisumarmo", "SOC", "Solo", "Indonesia", "2", "Solo");
            dataGridView1.Rows.Add("Aek Godang", "AEG", "Padang", "Indonesia", "2", "Padang");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox3.Text, textBox2.Text, comboBox1.Text, numericUpDown1.Text, textBox4.Text);
        }

        private void urururToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MasterMaskapai().Show();
            this.Hide();
        }

        private void masterJadwalPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MasterJadwal().Show();
            this.Hide();
        }

        private void masterKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MasterPromo().Show();
            this.Hide();
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UbahStatus().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
