using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    
    public class Product
    {
        private string _description;

        public Product(long code, string description, decimal price)
        {
            _description = description;
        }

        public void SetDescription(string description)
        {
            _description = description;
        }

        public string GetDescription()
        {
            return _description;
        }
    }
}
