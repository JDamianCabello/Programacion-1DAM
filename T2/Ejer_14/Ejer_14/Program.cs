using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_14
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BAASE = 8;
            const double ALTURA = 5.5;
            Console.WriteLine("Programa que calcula el área de un triángulo de {0} de base y {1} de altura.",BAASE,ALTURA);
            Console.WriteLine("\n\n\t\tla formula del área del triángulo es: ({0} * {1})/2 y da como resultado {2}",BAASE,ALTURA,BAASE*ALTURA/2);
            Console.WriteLine("\n\n\nPulsa una tecla para salir.");
            Console.ReadKey();
        }
    }
}
