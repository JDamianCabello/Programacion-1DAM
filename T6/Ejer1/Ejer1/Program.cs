using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = string.Empty;
            Console.WriteLine("Introduce una frase y la escibiré al revés:");
            Console.Write("Frase: ");
            frase = Console.ReadLine();
            Console.Write("\nTu texto al reves: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}",AlReves(frase));
            Console.ResetColor();
            Console.WriteLine("\nPulsa una tecla para salir....");
            Console.ReadKey();

        }

        static string AlReves(string s)
        {
            string aux = string.Empty;

            for(int i = s.Length - 1; i >= 0; i--)
                aux += s[i];
            return aux;
        }
    }
}
