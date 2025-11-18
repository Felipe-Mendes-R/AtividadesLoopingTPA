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
    public partial class frmatv1 : Form
    {
        public frmatv1()
        {
            InitializeComponent();
        }

        private void btncalc1_Click(object sender, EventArgs e)
        {
            int i, num1, num2;
            string resultado = "";

            i = 1;
            num1 = Convert.ToInt32(txtnum1.Text);

            if (num1 >= 1 && num1 < 10)
            {

                while (i <= 10)
                {
                    num2 = num1 * i;
                    resultado += num2.ToString() + "\r\n";
                    i++;
                }

            }
            else
            {
                txtresul.Text = "Erro! Digite um número de 1 a 9.";
            }

            txtresul.Text = resultado;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btncalc2_Click(object sender, EventArgs e)
        {
            int i, num1, num2;
            string resultado = "";

            i = 1;
            num1 = Convert.ToInt32(txtnum1.Text);

            if (num1 >= 1 && num1 < 10)
            {

                do
                {
                    num2 = num1 * i;
                    resultado += num2.ToString() + "\r\n";
                    i++;
                } while (i <= 10);

            }
            else
            {
                txtresul.Text = "Erro! Digite um número de 1 a 9.";
            }

                txtresul.Text = resultado;
        }

        private void btncalc3_Click(object sender, EventArgs e)
        {
            int i, num1, num2;
            string resultado = "";

            num1 = Convert.ToInt32(txtnum1.Text);

            if (num1 >= 1 && num1 < 10)
            {

                for (i = 1; i <= 10; i++)
                {
                    num2 = num1 * i;
                    resultado += num2.ToString() + "\r\n";
                }

            }
            else
            {
                txtresul.Text = "Erro! Digite um número de 1 a 9.";
            }

            txtresul.Text = resultado;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtresul.Clear();
            txtnum1.Clear();
            txtnum1.Focus();
        }
    }
}
