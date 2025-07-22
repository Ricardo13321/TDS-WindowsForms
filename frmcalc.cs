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
    public partial class frmcalc : Form
    {
        double primeiroNumero = 0;
        string operador = "";
        bool novoNumero = true;
        bool virgulaDigitada = false;
        public frmcalc()
        {
            InitializeComponent();
        }

        private void frmcalc_Load(object sender, EventArgs e)
        {
            lblConta.Text = "0";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (novoNumero)
            {
                lblConta.Text = btn.Text;
                novoNumero = false;
                virgulaDigitada = false;
            }
            else
            {
                if (lblConta.Text == "0" && btn.Text == "0")
                {
                    return;
                }
                if (lblConta.Text == "0" && btn.Text != "0")
                {
                    lblConta.Text = btn.Text;
                }
                else
                {
                    lblConta.Text += btn.Text;
                }
            }
            if (operador == "")
            {
                lblResultado.Text = lblConta.Text;
            }
            else
            {
                string primeiroNumStr = primeiroNumero.ToString();
                if (primeiroNumStr.Contains("."))
                {
                    primeiroNumStr = primeiroNumStr.Replace(".", ",");
                }
                lblResultado.Text = $"{primeiroNumStr} {operador} {lblConta.Text}";
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!virgulaDigitada)
            {
                if (lblConta.Text == "" || novoNumero)
                {
                    lblConta.Text = "0,";
                    novoNumero = false;
                }
                else
                {
                    lblConta.Text += ",";
                }
                virgulaDigitada = true;
            }
            if (operador == "")
            {
                lblResultado.Text = lblConta.Text;
            }
            else
            {
                string primeiroNumStr = primeiroNumero.ToString();
                if (primeiroNumStr.Contains("."))
                {
                    primeiroNumStr = primeiroNumStr.Replace(".", ",");
                }
                lblResultado.Text = $"{primeiroNumStr} {operador} {lblConta.Text}";
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!novoNumero && operador != "")
            {
                CalcularResultado();
            }

            primeiroNumero = double.Parse(lblConta.Text);
            operador = btn.Text;
            novoNumero = true;
            string primeiroNumeroStr = primeiroNumero.ToString();
            if (primeiroNumeroStr.Contains(","))
            {
                primeiroNumeroStr = primeiroNumeroStr.Replace(".", ",");
            }
            lblResultado.Text = $"{primeiroNumeroStr} {operador}";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string segundoNumeroString = lblConta.Text;
            string operadorAnterior = operador;
            CalcularResultado();
            string primeiroNumeoStr = primeiroNumero.ToString();
            if (primeiroNumeoStr.Contains(","))
            {
                primeiroNumeoStr = primeiroNumeoStr.Replace(".", ",");
            }
            lblResultado.Text = $"{primeiroNumeoStr} {operadorAnterior} {segundoNumeroString}";
            operador = "";
            novoNumero = true;
            virgulaDigitada = false;

        }

        private void CalcularResultado()
        {
            if (operador == "" || novoNumero)
            {
                return;
            }
            double segundoNumero = double.Parse(lblConta.Text);
            double resultado = 0;
            switch (operador)
            {
                case "+":
                    resultado = primeiroNumero+segundoNumero; 
                    break;
                case "-":
                    resultado = primeiroNumero-segundoNumero;
                    break;
                case "X":
                    resultado = primeiroNumero * segundoNumero;
                    break;
                case "/":
                    if (segundoNumero != 0)
                    {
                        resultado = primeiroNumero / segundoNumero;
                    }
                    else
                    {
                        MessageBox.Show("Não é possível realizar uma divisão por ero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblConta.Text = "0";
                        primeiroNumero = 0;
                        operador = "";
                        novoNumero = true;
                        virgulaDigitada = false;
                        lblResultado.Text = "0";
                        return;
                    }
                    break;
                default:
                    resultado = 0;
                    break;
            }
            lblConta.Text = resultado.ToString();
            primeiroNumero = resultado;
        }
    }
}
