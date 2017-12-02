using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer19
{
    class Program
    {
        static void Main(string[] args)
        {
            uint nivel = 0;
            Console.WriteLine("Programa que calcula todos los niveles de la serie de Fibonacci dado un nivel. desde el 1 hasta N");
            Console.Write("Dime hasta que nivel quieres calcular: ");
            try
            {
                nivel = uint.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Serie de Fibonacci hasta el nivel {0}",nivel);
                Console.WriteLine("=============================================");
                for(int i = 1; i <= nivel; i++)
                    Console.WriteLine("Nivel [{0}] -> {1}", i, Fibonacci((uint)i));
            }
            catch(FormatException) { Console.WriteLine("Error de formato."); }
            catch(ArgumentException) { Console.WriteLine("No se introdujo nada."); }
            catch(OverflowException) { Console.WriteLine("Número negativo o demasiado grande."); }
            catch { Console.WriteLine("Ni idea de que ha pasado."); }
            finally
            {
                Console.WriteLine("\n\nPulsa una tecla para salir...");
                Console.ReadKey();
            }
        }

        static double Fibonacci(uint nivel)
        {
            if (nivel == 0)
                return 0;
            if (nivel == 1)
                return 1;
            return Fibonacci(nivel - 1) + Fibonacci(nivel - 2);
        }
    }
}
