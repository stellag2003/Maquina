using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula05Maquina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefri_Click(object sender, EventArgs e)
        {
            double Comprar_Refri=double.Parse(txtValor.Text);

            if(Comprar_Refri <= 6.99)
            {
                MessageBox.Show("Saldo insuficiente :(");
            }

            else
            {
                MessageBox.Show("Compra realizada :)");
            }
        }

        private void btnChicle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSal_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValor.Text);

            if (valor == 2.67 || valor == 6.99 || valor == 20.00)
            {
                MessageBox.Show("Compra realizada :)");
            }

            else
            {
                MessageBox.Show("Saldo insuficiente :(");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
