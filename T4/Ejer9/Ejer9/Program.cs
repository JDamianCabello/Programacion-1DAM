using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            uint contador = 0;
            Double aux = 0;

            Console.WriteLine("Programa que calcula la media de X números. Acaba al introducir 0");
            do
            {
                Console.Write("Introduce un número: ");
                try
                {
                    aux = double.Parse(Console.ReadLine());
                    contador++;
                    total += aux;
                }
                catch (FormatException) { Console.WriteLine("Error de formato."); }
                catch (ArgumentException) { Console.WriteLine("No se introdujo nada."); }
                catch (OverflowException) { Console.WriteLine("Número negativo o demasiado grande."); }
                catch { Console.WriteLine("Ni idea de que ha pasado."); }
            } while (aux != 0);
            Console.WriteLine("\n\n\nLa media de los {0} valores es: {1}",contador,total/contador);
            Console.WriteLine("Pulsa una tecla para salir.");
            Console.ReadKey();
        }
    }
}
