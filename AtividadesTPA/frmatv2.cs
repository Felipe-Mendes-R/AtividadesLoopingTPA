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
    public partial class frmatv2 : Form
    {
        public frmatv2()
        {
            InitializeComponent();
        }

        private void btncalc1_Click(object sender, EventArgs e)
        {
            int i = 1;
            double celsius = 10;
            double fahren;

            while (i <= 10)
            {
                fahren = celsius * 1.8 + 32;
                txtresul.Text += fahren.ToString() + "\r\n";
                celsius += 10;
                i++;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtresul.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btncalc2_Click(object sender, EventArgs e)
        {
            int i = 1;
            double celsius = 10;
            double fahren;

            do
            {
                fahren = celsius * 1.8 + 32;
                txtresul.Text += fahren.ToString() + "\r\n";
                celsius += 10;
                i++;
            } while (i <= 10);
        }

        private void btncalc3_Click(object sender, EventArgs e)
        {
            int i;
            double celsius = 10;
            double fahren;

            for (i = 1; i <= 10; i++)
            {
                fahren = celsius * 1.8 + 32;
                txtresul.Text += fahren.ToString() + "\r\n";
                celsius += 10;
            }
        }
    }
}
