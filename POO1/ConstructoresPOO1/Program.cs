using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoresPOO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Botella b1 = new Botella("Marron", "Plastico");
            b1.Capacidad = 600;
            Console.WriteLine(b1.Material);
            Console.WriteLine(b1.Color);
            Console.WriteLine(b1.Capacidad);

            Botella b2 = new Botella();
        }
    }
}
