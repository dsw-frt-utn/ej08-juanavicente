using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class RetailSale : Sale
    {
        public RetailSale(decimal monto) : base(monto)
        {
        }

        public override decimal CalculateTotal()
        {
            return _monto;
        }
    }
}
