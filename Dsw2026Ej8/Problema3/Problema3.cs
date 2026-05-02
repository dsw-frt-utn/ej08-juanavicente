using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public static string CompararCopias(int OriginalValue, Product product)
        {
            int CopiarValue = OriginalValue;

            CopiarValue++;

            Product copiaProduct = product;

            copiaProduct.SetDescription("Producto Modificado");

            return $"{OriginalValue} - {CopiarValue} - {product.GetDescription()}";
        }
    }
}
