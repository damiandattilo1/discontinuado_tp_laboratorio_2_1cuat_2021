using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IConsumo
    {
        /// <summary>
        /// Verifica si el Producto cumple con la eficiencia para salir a la venta
        /// </summary>
        /// <returns></returns> TRue si es eficiente, de lo contrario False
        bool esEficiente();
    }
}
