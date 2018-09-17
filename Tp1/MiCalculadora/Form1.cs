using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1;
            double numero2;
            double result;
            string operador = btnOperar.Text;

            if(double.TryParse(txtNumero1.Text, out numero1) && (double.TryParse(txtNumero2.Text, out numero2)))
            {
                if(numero2 ==0 && operador== "/")
                {
                    lblResultado.Text = "No se puede /";

                }
                else
                {
                    Numero n1 = new Numero(numero1);
                    Numero n2 = new Numero(numero2);
                    result = Calculadora.Operar(n1, n1, operador);
                    lblResultado.Text = Convert.ToString(result);
                }
            }
            else
            {
                txtNumero1.Text = "";
                txtNumero2.Text = "";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string result;
           
            if(lblResultado.Text !="")
            {
            result = lblResultado.Text;
                Numero resultado = new Numero(lblResultado.Text);
                lblResultado.Text = resultado.BinarioDecimal(lblResultado.Text);
                result = resultado.DecimalBinario(result);
                lblResultado.Text = result;

            }
            
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            
            string result;

            if(lblResultado.Text !="")
            {
                result = lblResultado.Text;
                Numero resultado = new Numero(lblResultado.Text);
                lblResultado.Text = resultado.DecimalBinario(lblResultado.Text);
                result = resultado.BinarioDecimal(result);
                lblResultado.Text = result;

            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
