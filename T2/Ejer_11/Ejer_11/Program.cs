using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = string.Empty;
            Console.WriteLine("Hola, ¿como te llamas?");
            nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("{0}, bienvenido al mundo del .NET!", nombre);
            Console.WriteLine("\n\nPulsa una tecla para salir.");
            Console.ReadKey();
        }
    }
}
