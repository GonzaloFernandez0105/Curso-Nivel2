using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Persona
    {
        private string nombre;
        private int edad;
        private float sueldo;

        public string saludar()
        {
            return "Hola soy" + nombre;
        }
        public Persona (string nombre)
        {
            this.nombre = nombre;
        }
        

    }
}

