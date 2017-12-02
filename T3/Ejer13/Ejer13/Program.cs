using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer13
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            Console.WriteLine("Las comillas dobles ( \" ) son especiales dentro del método Write.");
            Console.WriteLine("Esto es una barra invertida \\.");
            Console.WriteLine("El carácter \"\\t\" es tabulación horizontal");
            Console.WriteLine("El carácter \"\\n\" es salto de línea");
            Console.WriteLine("EL los caracteres {{}} son especiales");
            Console.WriteLine("El primer valor se sustituye por {{0}} y vale: {0}",i);

            Console.ReadKey();
        }
    }
}
