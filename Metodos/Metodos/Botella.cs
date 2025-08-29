using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Botella
    {
        private int capacidad;
        private string color;
        private string material;

        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
           

        }
        public float recargar()
        {
            int cantidadActual = 30;
            int recarga = capacidad - cantidadActual;
            return cantidadActual + recarga; 
        }

    }
}
