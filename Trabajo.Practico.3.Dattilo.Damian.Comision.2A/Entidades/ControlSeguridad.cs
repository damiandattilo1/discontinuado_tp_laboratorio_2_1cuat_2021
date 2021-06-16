using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ControlSeguridad <T> where T: class
    {
        public int capacidadMaxima;
        public List<T> lista; // Lista GENERICA donde se agregan los productos

        /// <summary>
        /// Constructor donde se establece la capacidad y se instancia la lista generica
        /// </summary>
        /// <param name="capacidad"></param>
        public ControlSeguridad(int capacidad)
        {
            this.capacidadMaxima = capacidad;
            this.lista = new List<T>();
        }

        /// <summary>
        /// Metodo que agrega un producto a la lista
        /// </summary>
        /// <param name="aprobado"></param> objeto a agregar
        /// <returns></returns> TRue si se pudo agregar el objeto, de lo contrario False
        public bool Agregar(T aprobado)
        {
            return (this + aprobado);
        }

        /// <summary>
        /// Metodo estatico que verifica si un producto ya esta en la lista generica.
        /// </summary>
        /// <param name="control"></param> objeto conteniendo la lista
        /// <param name="aprobado"></param> producto a conparar
        /// <returns></returns>  True si el producto esta en la lista, de lo contrario false
        public static bool operator ==(ControlSeguridad<T> control, T aprobado)
        {
            bool flag = false;

            foreach (T item in control.lista)
            {
                if (item.Equals(aprobado))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public static bool operator !=(ControlSeguridad<T> control, T aprobado)
        {
            return !(control == aprobado);
        }

        /// <summary>
        /// Sobrecarga del operador + para agregar un objeto a la lista generica si queda lugar en la misma
        /// </summary>
        /// <param name="control"></param> instancia conteniendo la lista generica 
        /// <param name="aprobado"></param>  producto a agregar
        /// <returns></returns> True si se pudo agregar, de lo contrario False
        public static bool operator +(ControlSeguridad<T> control, T aprobado)
        {
            bool flag = false;
            bool esRepetido = (control == aprobado);
            
            if (control.lista.Count < control.capacidadMaxima && esRepetido == false)
            {
                control.lista.Add(aprobado);
                flag = true;
            }
            else if (esRepetido == true)
            {
                Console.WriteLine("El producto ya se encuentra en la lista!!!\n");
            }
            else
            {
                Console.WriteLine("Deposito completo!!!\n");
            }
            return flag;
        }

        /// <summary>
        /// Metodo para remover un producto de la lista generica
        /// </summary>
        /// <param name="aprobado"></param> Producto a agregar
        /// <returns></returns> True si se pudo agregar, de lo contrario False
        public bool Remover(T aprobado)
        {
            return (this - aprobado);
        }

        /// <summary>
        /// Sobrecarga del operador - para remover un producto de la lista generica
        /// </summary>
        /// <param name="control"></param> instancia con la lista generica
        /// <param name="aprobado"></param> Producto a remover
        /// <returns></returns> True si el producto pudo ser removido, de lo contrario false

        public static bool operator -(ControlSeguridad<T> control, T aprobado)
        {
            bool retorno = false;
            foreach (T item in control.lista)
            {
                 if (control == aprobado)
                 {
                    control.lista.Remove(item);
                    retorno = true;
                    break;
                 }
            }
            if(retorno == false)
            {
                Console.WriteLine("El producto no se encuentra en la lista\n");
            }
            return retorno;
        }


        /// <summary>
        /// Polimorfismo en to string para mostrar por pantalla la lista generica
        /// </summary>
        /// <returns></returns> Un string conteniendo todos los datos de la lista
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad Maxima = {this.capacidadMaxima}\n\nListado de productos aprobados:\n");

            foreach (T item in lista)
            {
                sb.AppendLine($"{item.ToString()}");
            }

            return sb.ToString();
        }

        

        public static implicit operator string (ControlSeguridad<T> control)
        {
            return control.ToString();
        }
    }
}
