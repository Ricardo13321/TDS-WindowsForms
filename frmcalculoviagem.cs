using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeAPPs
{
    public partial class frmcalculoviagem : Form
    {
        public frmcalculoviagem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float alcool = 4.27f;
            float gascomum = 6.28f;
            float gasaditi = 6.50f;
            float diesel = 5.93f;
            Int32 distancia = Convert.ToInt32(txtDistancia.Text.Trim());
            Int32 autonomia = Convert.ToInt32(txtAutonomia.Text.Trim());
            float tempo = distancia / 90;
            float litros = distancia / autonomia;
            float gasta = 0;
            if (cdbTipo.Text == "ÁLCOOL")
            {
                gasta = litros * alcool;
            }
            else if (cdbTipo.Text == "GASOLINA COMUM")
            {
                gasta = litros * gascomum;
            }
            else if (cdbTipo.Text == "GASOLINA ADITIVADA")
            {
                gasta = litros * gasaditi;
            }
            else if (cdbTipo.Text == "DIESEL")
            {
                gasta = litros * diesel;
            }
            lblLitrosGasto.Text = $"Litros gastos: {litros.ToString("F")}";
            lblGastoTotal.Text = $"Total: {gasta.ToString("C")}";
            lblTempo.Text = $"Tempo gasto previsto: {tempo.ToString("F")}";
        }
    }
}
