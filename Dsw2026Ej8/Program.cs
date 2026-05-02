using Dsw2026Ej8.Problema1;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Resolución de Problemas - DSW";

            Console.WriteLine("=====================================");
            Console.WriteLine("   RESOLUCIÓN DE PROBLEMAS EJ 08     ");
            Console.WriteLine("=====================================\n");

            Thread.Sleep(1500); 

            // =========================
            // PROBLEMA 1
            // =========================
            Console.WriteLine(">> PROBLEMA 1");
            Console.WriteLine("-----------------------------");


            ProductHelper helper = new ProductHelper();

            long code = 345789;
            string description = "Vela de Coco y Vainilla";
            decimal price = 1500.50m;

            string etiqueta = helper.ObtenerEtiquetaProducto(code, description, price);

            Console.WriteLine("--- Etiqueta Generada ---");
            Console.WriteLine(etiqueta);

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
