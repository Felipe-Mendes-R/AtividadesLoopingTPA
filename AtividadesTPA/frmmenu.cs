using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadesTPA
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void tsmiatv1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmatv1 atv1 = new frmatv1();
            atv1.Show();
        }

        private void tsmiatv2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmatv2 atv2 = new frmatv2();
            atv2.Show();
        }

        private void tsmiatv3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmatv3 atv3 = new frmatv3();
            atv3.Show();
        }

        private void tsmisair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
