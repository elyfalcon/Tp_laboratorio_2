using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
        }

        private void LaCalculadora_Load(object sender, EventArgs e)
        {
            txtNumero1.Focus();
        }


        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string result;

            if (lblResultado.Text != "")
            {
                //result = lblResultado.Text;
                Numero resultado = new Numero(lblResultado.Text);
                lblResultado.Text = resultado.DecimalBinario(lblResultado.Text);
                //result = resultado.DecimalBinario(result);
                //lblResultado.Text = result;

            }

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

            string result;

            if (lblResultado.Text != "")
            {
                //result = lblResultado.Text;
                Numero resultado = new Numero(lblResultado.Text);
                lblResultado.Text = resultado.BinarioDecimal(lblResultado.Text);
                //result = resultado.BinarioDecimal(result);
                //lblResultado.Text = result;

            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double numero1;
            double numero2;
            double result;
            string operador = cmbOperador.Text;

            try
            {
                if (double.TryParse(txtNumero1.Text, out numero1) && (double.TryParse(txtNumero2.Text, out numero2)))
                {
                    if (numero2 == 0 && operador == "/")
                    {
                        lblResultado.Text = "No se puede dividir";

                    }
                    else
                    {
                        Numero n1 = new Numero(numero1);
                        Numero n2 = new Numero(numero2);
                        result = Calculadora.Operar(n1, n2, operador);
                        lblResultado.Text = Convert.ToString(result);
                    }
                }
                else
                {
                    txtNumero1.Text = "";
                    txtNumero2.Text = "";
                }
            }
            catch (Exception ex) { lblResultado.Text = ex.Message; }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
            cmbOperador.Text = "";
        }

    }
}
