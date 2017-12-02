using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer20
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double nota = 0;
            int contador = -1;
            Console.WriteLine("Programa que calcula la media de una serie de números introducidos por teclado y finaliza al introducir un CERO.");
            do
            {
                Console.Write("\nIntroduce una nota: ");
                nota = double.Parse(Console.ReadLine());
                total += nota;
                contador++;
            } while (nota != 0);
            Console.WriteLine("La media de las {0} notas es {1}",contador,total/contador);
            Console.WriteLine("Pulsa una tecla para salir.");
            Console.ReadKey();
        }
    }
}
