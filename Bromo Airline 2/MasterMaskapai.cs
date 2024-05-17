using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bromo_Airline_2
{
    public partial class MasterMaskapai : Form
    {
        public MasterMaskapai()
        {
            InitializeComponent();
        }

        private void MasterMaskapai_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Adam Air", "PT. Adam Air", "16", "Adam Air adalah...");
            dataGridView1.Rows.Add("Aviastar", "PT. Aviastar", "12", "Aviastar adalah...");
            dataGridView1.Rows.Add("Batavia Air", "PT. Batavia Air", "6", "Batavia Air adalah...");
            dataGridView1.Rows.Add("Batik Air", "PT. Batik Air", "17", "Batik Air adalah...");
            dataGridView1.Rows.Add("Bouraq Indonesia Air", "PT. Bouraq Indonesia Air", "19", "Bouraq Indonesia adalah...");
            dataGridView1.Rows.Add("Citilink", "PT. Citilink", "12", "Citilink adalah...");
            dataGridView1.Rows.Add("Garuda Indonesia", "PT. Garuda Indonesia", "12", "Garuda Indonesia adalah...");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox3.Text, numericUpDown2.Text, textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
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
            this.Hide();
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UbahStatus().Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
