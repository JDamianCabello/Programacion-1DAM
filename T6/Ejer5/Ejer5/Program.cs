using System;

namespace Ejer5
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = string.Empty;
            Console.WriteLine("Programa que cuenta las palabras de una frase.");
            Console.Write("Escribe tu frase: ");
            frase = Console.ReadLine();

            Console.WriteLine("\n\n\n\nHay {0} palabras en tu frase.", totalPalabras(frase));
            Console.WriteLine("Pulsa una tecla para salir.....");

            Console.ReadKey();
        }

        static int totalPalabras(string frase)
        {
            char[] separadores = { ' ', ',', '.' };
            string[] contador = frase.Split(separadores,StringSplitOptions.RemoveEmptyEntries); 

            return contador.Length;
        }
    }
}
