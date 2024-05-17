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
    public partial class MasterJadwal : Form
    {
        public MasterJadwal()
        {
            InitializeComponent();
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

        private void label12_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void MasterJadwal_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("ID-7518", "Juanda", "Halim Pras", "Batik Air", "30-05-2024", "19:55", "01 jam 1 menit", "829891"); 
            dataGridView1.Rows.Add("IP-0203", "Juanda", "Soekarno Hatta", "Pelita Air", "30-05-...", "19:50", "01 jam 1 menit", "684060");
            dataGridView1.Rows.Add("QG-0719", "Juanda", "Soekarno Hatta", "Citilink", "30-05-...", "19:30", "01 jam 1 menit", "1317538"); 
            dataGridView1.Rows.Add("QG-0173", "Juanda", "Halim Pras", "Citilink", "30-05-...", "19:00", "01 jam 1 menit", "772601"); 
            dataGridView1.Rows.Add("GA-0325", "Juanda", "Soekarno Hatta", "Garuda Indonesia", "30-05-...", "18:40", "01 jam 1 menit", "1536888"); 
            dataGridView1.Rows.Add("QG-0737", "Juanda", "Halim Pras", "Citilink", "30-05-...", "18:40", "01 jam 1 menit", "1317538");
        }
    }
}
