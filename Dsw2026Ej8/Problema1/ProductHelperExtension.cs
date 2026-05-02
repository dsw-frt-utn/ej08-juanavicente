using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    partial class ProductHelper
    {
        private string GenerarTextoFormateado(long c, String d, decimal p)
        {
            return $"[{c}] {d} - {p:C}";
        }
    }
}