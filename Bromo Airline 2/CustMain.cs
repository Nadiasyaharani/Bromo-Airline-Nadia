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
    public partial class CustMain : Form
    {
        public CustMain()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CustMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TiketSaya().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ListPenerbangan().Show();
            this.Hide();
        }
        
        private void btnCreate_Click (object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
