using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer11
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            double totalPares = 0;
            double totalImpares = 0;
            int contador = 0;
            Console.WriteLine("Programa que lee por teclado números hasta introducir un 0, muestra la suma de los pares e imprime su cuadrado y suma los impares y muestra su media.");
            do
            {
                Console.Write("Introduce un número: ");
                numero = double.Parse(Console.ReadLine());
                if(numero % 2 == 0)
                    totalPares += numero;
                else
                {
                    totalImpares += numero;
                    contador++;
                }
            } while(numero != 0);
            Console.Clear();
            Console.WriteLine("RESULTADOS:");
            Console.WriteLine("===========");
            Console.WriteLine("PARES:");
            Console.WriteLine("\t    SUMA: {0}", totalPares);
            Console.WriteLine("\tCUADRADO: {0}", totalPares);
            Console.WriteLine("\nIMPARES:");
            Console.WriteLine("\t    SUMA: {0}", totalImpares);
            Console.WriteLine("\t   MEDIA: {0}", totalImpares/contador);
            Console.WriteLine("\n\nPulsa una tecla para salir.");
            Console.ReadKey();
        }
    }
}
