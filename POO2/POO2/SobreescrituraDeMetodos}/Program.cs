using SobreescrituraDeMetodos_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituraDeMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            a1.Nombre = "PEPE";
            Console.WriteLine(a1.ToString());
        }
    }
}
