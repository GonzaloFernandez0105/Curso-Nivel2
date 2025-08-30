using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();
            c1.Color = "Amarilla";
            c2.Color = "Roja";
            c3.Color = "Negra";

            List<Camioneta> listaCamionetas = new List<Camioneta>();

            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);
            Console.WriteLine("Cantidad de camionetas: " + listaCamionetas.Count);
            listaCamionetas[1].Color = "Azul";
          //  Console.WriteLine(listaCamionetas[1].Color);

           // listaCamionetas.Remove(c3);
           // Console.WriteLine("Cantidad de camionetas: " + listaCamionetas.Count);

            foreach (Camioneta item in listaCamionetas)
            {
                Console.WriteLine(item.Color);
            }
        }
    }
}
