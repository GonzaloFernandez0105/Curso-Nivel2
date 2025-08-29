using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Pepito");
            Console.WriteLine(p1.saludar());

            //Ejemplo Botella

            Botella b1 = new Botella("Marron", "Metal");
            Console.WriteLine(b1.recargar());
        
        }


       
    }
}
