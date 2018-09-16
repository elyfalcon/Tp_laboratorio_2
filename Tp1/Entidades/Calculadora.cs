using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {

        static public double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno;

            switch (ValidarOperador (operador))
            {
                case "+":
                    retorno = num1 + num2;
                    break;
                case "*":
                    retorno = num1 * num2;
                    break;
                case "/":
                    retorno = num1 / num2;
                    break;
                default:
                    return 0;
            }
            return retorno;

        }

        private static string  ValidarOperador(string operador)
            {
                string retorno;

                switch (operador)
                {
                    case "+":
                        retorno = operador;
                        break;
                    case "*":
                        retorno = operador;
                        break;
                    case "/":
                        retorno = operador;
                        break;
                    case "-":
                        retorno = operador;
                        break;
                    default:
                        retorno = "+";
                    break;
                }
                return retorno;

            }

    }
}
