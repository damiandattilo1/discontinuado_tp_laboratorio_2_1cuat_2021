using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        /// <summary>
        /// Realiza una operacion entre dos objetos Numero
        /// </summary>
        /// <param name="num1"></param> objeto 1
        /// <param name="num2"></param> objeto 2
        /// <param name="operador"></param> el operador para la operacion
        /// <returns></returns> el resultado en variable double
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            int operadorInt;
            string operadorString;
            char operadorChar;

            operadorString = Calculadora.ValidarOperador(Convert.ToChar(operador));
            operadorChar = Convert.ToChar(operadorString);
            operadorInt = operadorChar;

            if (operadorInt == 43)
            {
                return num1 + num2;
            }
            else if (operadorInt == 45)
            {
                return num1 - num2;
            }
            else if (operadorInt == 47)
            {
                return num1 / num2;
            }
            else if (operadorInt == 42)
            {
                return num1 * num2;
            }
            else
            {
                return 5;
            }

        }

        /// <summary>
        /// Valida que el char recibido contenga un operador valido
        /// </summary>
        /// <param name="operador"></param> variable char con el operador
        /// <returns></returns> el operador convertido en string, o el operador + si el operador no era valido
        private static string ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return Char.ToString(operador);
            }
            else
            {
                return Char.ToString('+');
            }
        }

    }
}
