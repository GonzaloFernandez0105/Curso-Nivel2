using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulo = new Articulo[10];
            
            for (int i = 0; i < 10; i++)
            {
                articulo[i] = new Articulo();
                Console.WriteLine("Ingrese los datos del producto");
                Console.WriteLine("Inserte el codigo del articulo: ");
                articulo[i].codArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserte el Precio:");
                articulo[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Inserte el Codigo de Marca:");
                articulo[i].codMarca = int.Parse(Console.ReadLine());
            }


            // Ejemplo Ventas

            Venta venta = new Venta();
            Console.WriteLine("Codigo de Cliente:");   
            venta.codCliente = int.Parse(Console.ReadLine());
            while (venta.codCliente != 0)
            {
            Console.WriteLine("Ingrese la venta:");
            Console.WriteLine("Codigo Articulo:");
            venta.codArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad:");
            venta.Cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Codigo de Cliente:");
            venta.codCliente = int.Parse(Console.ReadLine());

            }
        }
    }
}
