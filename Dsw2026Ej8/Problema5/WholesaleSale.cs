using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal monto) : base(monto)
        {
        }

        public override decimal CalculateTotal()
        {
            return _monto * 0.9m; 
        }
    }
}
