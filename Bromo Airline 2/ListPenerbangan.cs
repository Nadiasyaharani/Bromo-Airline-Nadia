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
    public partial class ListPenerbangan : Form
    {
        public ListPenerbangan()
        {
            InitializeComponent();
        }

        private void ListPenerbangan_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            new BeliTiket().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CustMain().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
