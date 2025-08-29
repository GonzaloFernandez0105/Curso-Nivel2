using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Persona
    {
        private int Edad;
        private string Nombre;
        private float Sueldo;

        public void setEdad ( int e)
        {
            Edad = e;
        }
        public int getEdad()
        {
            return Edad;
        }


    }
}
