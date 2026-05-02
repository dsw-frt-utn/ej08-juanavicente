using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Dsw2026Ej8
{
    public static class Problema6
    {
        public static string NormalizarCodigoProducto(string code)
        {
            if (code == null)
            {
                return "SIN-CODIGO";
            }

            return code.ToProductCode();
        }
    }
}
