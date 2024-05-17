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
    public partial class TiketSaya : Form
    {
        public TiketSaya()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CustMain().Show();
            this.Hide();
        }

        private void TiketSaya_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("IF-0203", "Pelita Air Service", "Juanda", "Soekarno Hatta", "22-05-2023",
                "19:50 - 21:25", "Delay (Selama 1 jam)");
        }
    }
}
