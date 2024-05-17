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
    public partial class BeliTiket : Form
    {
        public BeliTiket()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CustMain().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ListPenerbangan().Show();
            this.Hide();
        }
    }
}
