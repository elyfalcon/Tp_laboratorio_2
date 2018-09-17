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

        public void SetNumero(string strnumero)
        {
            numero = ValidarNumero(strnumero);
        }


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

        public string BinarioDecimal(string binario)
        {
            double num = 0;
            string retorno=" ";
            int cont = 0;
            for(int i=binario.Length -1; i > -1;i--)
            {
                string aux = binario.Substring(i, 1);
                if (aux.Equals("1"))
                {
                    num += (double)Math.Pow(2, cont);
                }
                else
                {

                }
                cont++;

                //if (binario[i].ToString().Equals("1")) { }
                //{
                //    num+=(double) Math.Pow(2, i);
                //}
                //else
                //{

                //}
            }

            if (num >0)
            {
                retorno = Convert.ToString(num);
                
            }
            return retorno;

            
  
        }
        public string DecimalBinario(double numero)
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
            binario = "1" + binario;
            return binario;
        }
        public string DecimalBinario(string numero)
        {
            
            SetNumero(numero);
            //num = Convert.ToDouble(numero);
            if(this.numero !=0)
            {
            return DecimalBinario(this.numero);
            }
            else
            {
                return "Valor Invalido";
            }

        }

       





        #endregion
    }
}
