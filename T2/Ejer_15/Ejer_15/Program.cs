using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio = 0;
            Console.WriteLine("Programa que calcula el área de una circunferencia dado un radio.");
            Console.Write("Dime el radio: ");
            radio = double.Parse(Console.ReadLine());
            Console.WriteLine("\n\n\t\tEl área del círculo es: {0}",Math.PI*Math.Pow(radio,2));
            Console.WriteLine("\n\nPulsa una tecla para salir.");
            Console.ReadKey();
        }
    }
}
