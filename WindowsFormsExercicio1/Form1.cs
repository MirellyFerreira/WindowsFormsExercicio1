using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
           double resultado = double.Parse(txtEnergia.Text) + double.Parse(txtAgua.Text) + double.Parse(txtTV.Text) + double.Parse(txtAlimentacao.Text) + double.Parse(txtOutros.Text);
           lblGastos.Text = resultado.ToString();

            double saldo = resultado - double.Parse(txtRenda.Text);
            lblSaldo.Text = saldo.ToString();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Console.Clear();
        }

        private void totaldegastos_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }
    }
}
