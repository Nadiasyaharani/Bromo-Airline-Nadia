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
    public partial class MasterPromo : Form
    {
        public MasterPromo()
        {
            InitializeComponent();
        }

        private void MasterPromo_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("BROMOAJAYUK", "15", "100000", "09-09-2023", "Yuk pakai disk...");
            dataGridView1.Rows.Add("NAIKBROMOAI", "10", "150000", "09-09-2023", "Bromo Airlines");
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UbahStatus().Show();
            this.Hide();
        }

        private void hhdhdhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MasterBandara().Show();
            this.Hide();
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

        private void label10_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
