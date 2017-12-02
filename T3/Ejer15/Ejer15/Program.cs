using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer15
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Programa que que lee dos valores X e Y y muestra el mensaje VERDADERO si X es mayor que Y y FALSO en otro caso.");
            Console.Write(" Introduce el primer número: ");
            x=double.Parse(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            y=double.Parse(Console.ReadLine());
            if(x>y)
                Console.WriteLine("\n\nVerdadero.");
            else
                Console.WriteLine("\n\nFalso.");
            Console.WriteLine("\nPulsa una tecla para salir.");
            Console.ReadKey();
        }
    }
}
