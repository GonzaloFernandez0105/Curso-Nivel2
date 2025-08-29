using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoresPOO1
{
    internal class Botella
    {
        private int capacidad;
        private string color;
        private string material;

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
       
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
        }

        //Sobrecargar el constructor
        public Botella()
        {

        }

        public string Color
        {
            get { return color; }
        }
        public string Material
        {
            get { return material; }
        }
    }
}
