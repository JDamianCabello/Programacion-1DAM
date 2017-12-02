using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7
{
    class Program
    {
        static void Main(string[] args)
        {
            double maximo = double.MinValue;
            double minimo = double.MaxValue;
            double numero;
            Console.WriteLine("Programa que pide numeros hasta meter un 0, despues muestra el máximo y el mínimo que se hayan introducido.");
            do
            {
                Console.Write("Introduce un número: ");
                if(double.TryParse(Console.ReadLine(),out numero))
                {
                    if (numero < minimo)
                        minimo = numero;
                    if (numero > maximo)
                        maximo = numero;
                }
            } while (numero != 0);
            Console.Clear();
            Console.WriteLine("           Fin");
            Console.WriteLine("===============================");
            Console.WriteLine("El máximo es: {0:F2}", maximo);
            Console.WriteLine("El mínimo es: {0:F2}", minimo);
            Console.WriteLine("\n\nPulsa una tecla para salir.");
            Console.ReadKey();
        }
    }
}
