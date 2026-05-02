using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        protected decimal _monto;

        public Sale(decimal monto)
        {
            _monto = monto;
        }

        public virtual decimal CalculateTotal()
        {
            return _monto;
        }
    }
}
