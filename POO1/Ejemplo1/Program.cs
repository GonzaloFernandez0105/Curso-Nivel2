using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo Persona        
            Persona p1 = new Persona();
            p1.setEdad(30);
           Console.WriteLine("Edad: " + p1.getEdad()); 

            //Ejemplo Botella
            Botella b1 = new Botella();
            b1.Capacidad = 600;
            Console.WriteLine("Capacidad: " + b1.Capacidad);

        }
    }
}
