using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AireAcondicionado : Producto, IConsumo
    {
        public ETipo tipo;

        /*public AireAcondicionado()
        {

        }*/

        /// <summary>
        /// Constructor de Aire Acondicionado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eficiencia"></param>
        /// <param name="tipo"></param>

        public AireAcondicionado(int id, EficienciaEnergetica eficiencia, ETipo tipo) : base(id, eficiencia)
        {
            this.tipo = tipo;
            //this.Eficiencia = eficiencia;
        }

        /// <summary>
        /// Propiedad de Tipo
        /// </summary>
        public ETipo Tipo
        {
            get
            {
                return this.tipo;
            }
        }

        /*public EficienciaEnergetica Eficiencia
        {
            get
            {

            }
            set
            {

            }
        }*/

        /// <summary>
        /// Sobrecarga de operador de igualdad
        /// </summary>
        /// <param name="ac1"></param>  objeto 1 de Aire Acondicionado
        /// <param name="ac2"></param> objeto 2 de Aire Acondicionado
        /// <returns></returns> true si los tipos son iguales
        public static bool operator ==(AireAcondicionado ac1, AireAcondicionado ac2)
        {
            return (ac1.Tipo == ac2.Tipo);
        }

        public static bool operator !=(AireAcondicionado ac1, AireAcondicionado ac2)
        {
            return !(ac1 == ac2);
        }

        /// <summary>
        /// Polimorfismo de To String para mostrar por pantalla
        /// </summary>
        /// <returns></returns>  Un string conteniendo los datos del producto 
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString()}");
            sb.AppendLine($"Tamanio: {this.Tipo}");
            if(this.esEficiente())
            {
                sb.AppendLine("El producto esta aprobado");
            }
            else
            {
                sb.AppendLine("El producto necesita ser revisado");
            }
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool rta = false;

            if (obj is AireAcondicionado)
            {
                rta = this == (AireAcondicionado)obj;
            }

            return rta;
        }

        /// <summary>
        /// Interface que verifica si el producto esta aprobado para su comercializacion
        /// </summary>
        /// <returns></returns> TRue si la eficiencia energetica es A, de lo contrario False
        public bool esEficiente()
        {
            bool retorno = false;

            if(this.Eficiencia == EficienciaEnergetica.A)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
