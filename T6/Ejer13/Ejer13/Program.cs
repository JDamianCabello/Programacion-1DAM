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
            string frase = string.Empty;
            Console.WriteLine("Programa que muestra la lista de palabras empezando por mayúscula cada una de ellas.");
            Console.WriteLine("NOTA: los separadores de palabras son: [Espacio],[-],[|].");
            Console.Write("Introduce tu frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("\n\n");

            Palabras(frase);

            Console.WriteLine("\n\nFin... Pulsa una tecla para salir....");
            Console.ReadKey();
        }

        static void Palabras(string frase)
        {
            char[] separadores = { '-', '|',' ' };
            string[] palabras = frase.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < palabras.Length; i++)
                Console.WriteLine("[{0}]: {1}{2}", i + 1, palabras[i][0].ToString().ToUpper(), palabras[i].Substring(1));
        }
    }
}
