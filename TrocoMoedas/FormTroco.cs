using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocoMoedas
{
    public partial class FormTroco12 : Form
    {
        public FormTroco12()
        {
            InitializeComponent();
        }

        private void lbl_calcular_Click(object sender, EventArgs e)
        {
            decimal valorCompra;
            decimal valorPagoDinheiro;
            decimal valorTroco;

            valorCompra = Convert.ToDecimal(txtbox_Valorcompra.Text);
            valorPagoDinheiro = Convert.ToDecimal(txtbox_valorpago.Text);

            valorTroco = valorPagoDinheiro - valorCompra;

            txtbox_Valortroco.Text = valorTroco.ToString();

            int moedas1 = (int)(valorTroco / 1m);
            lbl_troco1.Text = moedas1.ToString();
            valorTroco = valorTroco % 1;

            int moedas050 = (int)(valorTroco / 0.050m);
            lbl_troco50.Text = moedas050.ToString();
            valorCompra = valorTroco % 0.50m;

            int moedas025 = (int)(valorTroco / 0.025m);
            lbl_troco25.Text = moedas025.ToString();
            valorTroco = valorTroco % 0.25m;

            int moedas10 = (int)(valorTroco * 0.10m);
            lbl_troco10.Text = moedas10.ToString();
            valorTroco = valorTroco % 0.10m;

            int moedas005 = (int)(valorTroco * 0.05m);
            lbl_troco005.Text = moedas005.ToString();
            valorTroco = valorTroco % 0.05m;

            int moedas001 = (int)(valorTroco * 0.01m);
            lbl_troco001.Text = moedas001.ToString();
            valorTroco = valorTroco % 0.1m;

        }
    }
}