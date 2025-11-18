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
    public partial class frmatv3 : Form
    {
        public frmatv3()
        {
            InitializeComponent();
        }

        DialogResult result = DialogResult.Yes;
        string strcomodos = "";
        int areac, areat = 0, contador = 0;

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtresul.Clear();
            txtnum2.Clear();
            txtnum1.Clear();
            txtnum1.Focus();

            areac = 0;
            areat = 0;
            contador = 0;
            strcomodos = "";
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int comprimento, largura;
            largura = Convert.ToInt32(txtnum2.Text);
            comprimento = Convert.ToInt32(txtnum1.Text);

            areac = largura * comprimento;
            areat += areac;

            contador++;
            strcomodos += "Área do cômodo " + contador + ": " + areac + "\r\n";

            result = MessageBox.Show("Deseja adicionar mais um cômodo?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                txtnum1.Clear();
                txtnum2.Clear();
            }
            else
            {
                txtresul.Text = strcomodos + "Área total: " + Convert.ToString(areat);
            }
            txtnum1.Focus();
        }
    }
}
