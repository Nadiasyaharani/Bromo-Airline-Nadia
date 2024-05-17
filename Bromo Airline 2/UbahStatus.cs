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
    public partial class UbahStatus : Form
    {
        public UbahStatus()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void masterKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MasterPromo().Show();
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
