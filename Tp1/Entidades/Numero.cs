using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;




       private static double ValidarNumero(string Numero)
        {
            double num;
            bool esNumero;
            esNumero = double.TryParse(Numero, out num);

            if (esNumero)
            {
                num = double.Parse(Numero);
            }
            else
            {
                num = 0;
            }
            return num;
        }
        private void SetNumero(string numero)
        {
            this.numero = ValidarNumero(numero);
        }

        public Numero() { }

        public Numero(double numero) : this(numero.ToString()) { }

        public Numero(string numero)
        {
            SetNumero(numero);
        }

        #region Sobrecargas
        public static double operator +(Numero num1,Numero num2)
        {
            return num1.numero + num2.numero;
        }
        public static double operator *(Numero num1,Numero num2)
        {
            return num1.numero * num2.numero;
        }
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }
        public static double operator /(Numero num1, Numero num2)
        {
            return num1.numero / num2.numero;
        }
        #endregion
        #region Metodos

        public static string BinarioDecimal(string binario)
        {
            double num = 0;
            string retorno=" ";

            for(int i=binario.Length; i > 0;i--)
            {
                if(binario[i]==1)
                {
                    num+=(double) Math.Pow(2, i);
                }
                else
                {

                }
            }
            if(num >0)
            {
                retorno = Convert.ToString(num);
                
            }
            return retorno;

            
  
        }
        public static string DecimalBinario(double numero)
        {
            string binario = "";
            if(numero <0)
            {
                return "Valor Invalido";
            }
            while (numero > 1)
            {
                if (numero % 2 == 1)
                {
                    binario = "1" + binario;
                }
                else
                {
                    binario = "0" + binario;
                }

                numero = (int)numero / 2;
            }
            return binario;
        }
        public static string DecimalBinario(string numero)
        {
            double num;
            num = Convert.ToDouble(numero);
            return DecimalBinario(numero);

        }





        #endregion
    }
}
