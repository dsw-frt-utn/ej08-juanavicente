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

            Thread.Sleep(1500);

            // =========================
            // PROBLEMA 2
            // =========================
            Console.WriteLine(">> PROBLEMA 2");
            Console.WriteLine("-----------------------------");

            long productCode = 345788;
            string productDescription = "Vela de Lavanda";
            int quantity = 3;
            decimal unitPrice = 1200.75m;

            string resumen = Problema2.CrearResumenVenta(productCode, productDescription, quantity, unitPrice);

            Console.WriteLine("Datos de entrada:");
            Console.WriteLine($"Código: {productCode}");
            Console.WriteLine($"Descripción: {productDescription}");
            Console.WriteLine($"Cantidad: {quantity}");
            Console.WriteLine($"Precio unitario: {unitPrice}");

            Thread.Sleep(750);

            Console.WriteLine("\nResultado:");
            Console.WriteLine(resumen);

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Thread.Sleep(1500);

            // =========================
            // PROBLEMA 3
            // =========================
            Console.WriteLine(">> PROBLEMA 3");
            Console.WriteLine("-----------------------------");

            int OriginalValue = 10;
            Product producto = new Product(345789, "Vela de Coco y Vainilla", 1500.50m);

            Console.WriteLine("Antes de llamar al método:");
            Console.WriteLine($"Valor original: {OriginalValue}");
            Console.WriteLine($"Descripción del producto: {producto.GetDescription()}");

            string resultado = Problema3.CompararCopias(OriginalValue, producto);

            Thread.Sleep(750);

            Console.WriteLine("\nResultado"); Console.WriteLine(resultado);

            Console.WriteLine("\nDespués de llamar al método:");
            Console.WriteLine($"Valor original: {OriginalValue}");
            Console.WriteLine($"Descripción del producto: {producto.GetDescription()}");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Thread.Sleep(1500);

            // =========================
            // PROBLEMA 4
            // =========================
            Console.WriteLine(">> PROBLEMA 4");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Nota 1: 8");
            Console.WriteLine("Nota 2: null");
            Console.WriteLine("Nota 3: 10");

            double promedio = Problema4.CalcularPromedio(8, null, 10);
            
            Thread.Sleep(750);

            Console.WriteLine($"\nPromedio: {promedio}");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
