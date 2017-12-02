using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer17
{
    class Program
    {
        static void Main(string[] args)
        {
            double divisor = 0;
            double dividendo = 0;
            Console.WriteLine("Programa que calcula el resto de una division dado el dividendo y el divisor.");
            Console.Write("Introduzca el dividendo: ");
            dividendo = double.Parse(Console.ReadLine());
            Console.Write("  Introduzca el divisor: ");
            divisor = double.Parse(Console.ReadLine());
            Console.CursorVisible = false;
            Console.WriteLine("\n\n\nResultado con cociente y resto:");
            Console.WriteLine("{0} ÷ {1} = {2:F0} y de resto {3}", dividendo,divisor,dividendo/divisor,RestoDivision(dividendo,divisor));
            Console.WriteLine("\nResultado con decimales:");
            Console.WriteLine("{0} ÷ {1} = {2:F2}", dividendo,divisor,dividendo/divisor);
            Console.WriteLine("\n\n\nPulsa una tecla para salir.");
            Console.ReadKey();
        }

        static double RestoDivision(Double dividendo, double divisor)
        {
            return dividendo - (divisor * Convert.ToInt32(dividendo / divisor));
        }
    }
}
