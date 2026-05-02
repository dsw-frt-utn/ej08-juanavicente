using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public static double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int suma = 0;
            int cantidadNotas = 0;

            if (nota1.HasValue && nota1 >= 0 && nota1 <= 10)
            {
                suma += nota1.Value;
                cantidadNotas++;
            }
            if (nota2.HasValue && nota2 >= 0 && nota2 <= 10)
            {
                suma += nota2.Value;
                cantidadNotas++;
            }
            if (nota3.HasValue && nota3 >= 0 && nota3 <= 10)
            {
                suma += nota3.Value;
                cantidadNotas++;
            }
            if (cantidadNotas == 0)
            {
                return 0; // Evitar división por cero
            }
             return (double)suma / cantidadNotas;
            
        }
    }
}
