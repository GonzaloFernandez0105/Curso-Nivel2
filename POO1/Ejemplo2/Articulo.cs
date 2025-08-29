using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Articulo
    {
        public int codArticulo { get; set; }
        public float Precio { get; set; }

        private int codigoMarca;

       public int codMarca
        {
            get {  return codigoMarca; }
            set 
            {   if (codMarca >= 1 && codMarca <= 10)                
                    codMarca = value;
                else
                    codMarca = -1;
            }
        }
    }
}
