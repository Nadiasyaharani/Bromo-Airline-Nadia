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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void urururToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MasterMaskapai().Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void hhdhdhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MasterBandara().Show();
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
            this.Hide(); ;
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UbahStatus ().Show();
            this.Hide();
        }
    }
}
