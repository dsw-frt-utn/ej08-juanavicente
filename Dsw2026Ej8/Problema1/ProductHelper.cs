using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema1
{
    public partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, String description, decimal price) 
        { 
            return GenerarTextoFormateado(code, description, price);
        }
    }
}
