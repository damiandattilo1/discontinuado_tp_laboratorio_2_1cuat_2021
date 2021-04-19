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

        /// <summary>
        /// Carga un valor ya validado en el atributo numero
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = Numero.ValidarNumero(value);
            }
        }

        /// <summary>
        /// Constructor sin parametros
        /// </summary>

        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor que recibe una variable double y la asigna al atributo numero en esta instancia
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que recibe un string y lo asigna al atributo numero en esta instancia
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }


        /// <summary>
        /// Recibe un string y, si es binario, lo convierte a decimal
        /// </summary>
        /// <param name="binario"></param> el string a convertir
        /// <returns></returns> el string ya convertido, o el mismo string si este ya era decimal
        public static string BinarioDecimal(string binario)
        {
            int j = 1;
            int resultado = 0;
            if (!Numero.esBinario(binario))
            {
                return binario;
            }
            else
            {
                for (int i = binario.Length - 1; i >= 0; i--)
                {
                    if ((binario[i]) == '1')
                    {
                        resultado = resultado + j;
                    }
                    j = j * 2;
                }

                return Convert.ToString(resultado);
            }
        }

        /// <summary>
        /// Recibe una variable double y, si es decimal, la convierte a binario
        /// </summary>
        /// <param name="numero"></param> la variable double a convertir
        /// <returns></returns> la variable ya convertida y parseada a string, o la misma variable si esta ya era binario
        public static string DecimalBinario(double numero)
        {
            string resultado = "00";
            string res = "00";
            int numeroInt = (int)numero;
            if (numeroInt == 0)
            {
                return "0";
            }
            else if (numeroInt == 1)
            {
                return "1";
            }
            else
            {
                if (numeroInt % 2 == 1)
                {
                    resultado = string.Format("{0}", '1');
                }
                else if (numeroInt % 2 == 0)
                {
                    resultado = string.Format("{0}", '0');
                }
                numeroInt = numeroInt / 2;
                while (numeroInt != 1)
                {
                    // Console.WriteLine("{0}", numero % 2);
                    if (numeroInt % 2 == 1)
                    {
                        resultado = string.Format("{0}{1}", resultado, '1');
                    }
                    else if (numeroInt % 2 == 0)
                    {
                        resultado = string.Format("{0}{1}", resultado, '0');
                    }
                    numeroInt = numeroInt / 2;
                }

                resultado = string.Format("{0}{1}", resultado, '1');
                res = string.Format("{0}", resultado[resultado.Length - 1]);
                for (int i = resultado.Length - 2; i >= 0; i--)
                {
                    res = string.Format("{0}{1}", res, resultado[i]);
                }
            }
            return res;
        }

        /// <summary>
        /// Accede al metodo DecimalBinario
        /// </summary>
        /// <param name="numero"></param> string a convertir en binario
        /// <returns></returns> string con el resultado
        public static string DecimalBinario(string numero)
        {
            if (Numero.esBinario(numero))
            {
                return numero;
            }
            else
            {
                double numeroDouble = Convert.ToDouble(numero);
                return Numero.DecimalBinario(numeroDouble);
            }
        }

        /// <summary>
        /// Averigua si un numero es binario
        /// </summary>
        /// <param name="binario"></param> El numero en string
        /// <returns></returns> false si no es binario, true si es binario
        private static bool esBinario(string binario)
        {
            int esBinario = 1;

            for (int i = 0; i < binario.Length; i++)
            {

                if (binario[i] != '0' && binario[i] != '1')
                {
                    esBinario = 0;
                    break;
                }
            }

            if (esBinario == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="n1"></param> objeto 1
        /// <param name="n2"></param> objeto 2
        /// <returns></returns> la suma de los atributos numero de los dos objetos
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="n1"></param> objeto 1
        /// <param name="n2"></param> objeto 2
        /// <returns></returns> la resta de los atributos numero de los dos objetos
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// sobrecarga del operador *
        /// </summary>
        /// <param name="n1"></param> objeto 1
        /// <param name="n2"></param> objeto 2
        /// <returns></returns> la multiplicacion de los atributos numero de los dos objetos
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador /
        /// </summary>
        /// <param name="n1"></param> objeto 1
        /// <param name="n2"></param> objeto 2
        /// <returns></returns> la division de los atributos numero de los dos objetos
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }

        /// <summary>
        /// Valida que un string contenga un caracter numerico
        /// </summary>
        /// <param name="strNumero"></param> el string a validar
        /// <returns></returns> 0 si el string no contiene un caracter numerico, o el contenido del string convertido en double si el string contiene un caracter numerico
        private static double ValidarNumero(string strNumero)
        {
            double numero;
            if (!double.TryParse(strNumero, out numero))
            {
                return 0;
            }
            else
            {
                return numero;
            }
        }
    }
}
