using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer18
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio = 0;
            double altura = 0;
            Console.WriteLine("Programa que calcula el lateral y el volumen de un cilindro recto dados un radio y una altura.");
            Console.Write("Introduce la altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("Introduce el radio: ");
            radio = double.Parse(Console.ReadLine());
            Console.WriteLine("\n\n=============================");
            Console.WriteLine("       C A L C U L O S");
            Console.WriteLine("=============================");
            Console.WriteLine("El volumen es: {0:F2}", Math.PI * Math.Pow(radio, 2) * altura);
            Console.WriteLine("El   área  es: {0:F2}", 2 * Math.PI * radio * altura);
            Console.WriteLine("\n\n\nPulsa una tecla para salir.");
            Console.ReadKey();
        }
    }
}
