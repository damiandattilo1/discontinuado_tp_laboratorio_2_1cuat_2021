using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Microondas : Producto, IConsumo
    {
        public ETamanio tamanio;

        /*public Microondas()
        {

        }*/

        /// <summary>
        /// Constructor de Microondas
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eficiencia"></param>
        /// <param name="tamanio"></param>
        public Microondas(int id, EficienciaEnergetica eficiencia, ETamanio tamanio) : base(id, eficiencia)
        {
            this.tamanio = tamanio;
        }

        /// <summary>
        /// Propiedad de tamaño
        /// </summary>
        public ETamanio Tamanio
        {
            get
            {

                return this.tamanio;
            }
        }


        /// <summary>
        /// Sobrecarga del operador de igualdad
        /// </summary>
        /// <param name="m1"></param> objeto 1 de microondas
        /// <param name="m2"></param> objeto 2 de Microondas
        /// <returns></returns> TRue si los tamanos son iguales, de lo contrario False
        public static bool operator ==(Microondas m1, Microondas m2)
        {
            return (m1.Tamanio == m2.Tamanio && (Producto)m1 == (Producto)m2);
        }

        public static bool operator !=(Microondas m1, Microondas m2)
        {
            return !(m1 == m2);
        }

        /// <summary>
        /// Polimorfismo de To String para mostrar por pantalla
        /// </summary>
        /// <returns></returns> Un string conteniendo todos los datos del Microondas
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString()}");
            sb.AppendLine($"Tamanio: {this.Tamanio}");
            if (this.esEficiente())
            {
                sb.AppendLine("El producto esta aprobado");
            }
            else
            {
                sb.AppendLine("El producto necesita ser revisado");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Interface que verifica si el Microondas esta aprobado para su comercializacion
        /// </summary>
        /// <returns></returns> booleano True si la eficiencia energetica es A o B, de lo contrario False
        public bool esEficiente()
        {
            bool retorno = false;

            if (this.Eficiencia == EficienciaEnergetica.A || this.Eficiencia == EficienciaEnergetica.B)
            {
                retorno = true;
            }

            return retorno;
        }

        public override bool Equals(object obj)
        {
            bool rta = false;

            if (obj is Microondas)
            {
                rta = this == (Microondas)obj;
            }

            return rta;
        }
    }
}
