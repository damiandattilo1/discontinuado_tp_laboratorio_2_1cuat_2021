using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected int id;
        protected EficienciaEnergetica eficiencia;

        /// <summary>
        /// Constructor de producto
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eficiencia"></param>
        public Producto (int id,  EficienciaEnergetica eficiencia)
        {
            this.id = id;
            this.eficiencia = eficiencia;
        }

        /// <summary>
        /// Propiedad para Id
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }
        }

        /// <summary>
        /// Propiedad para eficiencia energetica
        /// </summary>
        public EficienciaEnergetica Eficiencia
        {
            get
            {
                return this.eficiencia;
            }
        }

        /// <summary>
        /// Sobrecarga del operador de igualdad
        /// </summary>
        /// <param name="p1"></param> Objeto 1 de producto
        /// <param name="p2"></param> Objeto 2 de Producto
        /// <returns></returns>  True si los Id son iguales, de lo contrario False
        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.Id == p2.Id);
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Polimorfismo en To String para mostrar por pantalla
        /// </summary>
        /// <returns></returns> Un string conteniendo los datos del producto
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine($"Eficiencia energetica: {this.Eficiencia}");
            return sb.ToString();
        }

        
    }

}
