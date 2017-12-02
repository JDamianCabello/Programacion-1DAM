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
            int medio = 0;
            bool salida = false;
            do
            {
                Console.Write("Dime el total de niveles del arbol: ");
                try
                {
                    medio = int.Parse(Console.ReadLine());
                    if (medio <= 100 && medio >= 5)
                    {
                        medio = medio * 2 - 1;
                        for (int i = 0; i < medio; i += 2)
                        {
                            for (int j = 0; j < medio - i; j += 2)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 0; k <= i; k++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            Console.CursorLeft = medio / 2;
                            Console.WriteLine("***");
                        }
                        salida = true; 
                    }
                    else
                        Console.WriteLine("Solo son válidos valores entre 5 y 100 ambos incluidos.");
                }
                catch (FormatException) { Console.WriteLine("Error de formato."); }
                catch (ArgumentException) { Console.WriteLine("No se introdujo nada."); }
                catch (OverflowException) { Console.WriteLine("Número negativo o demasiado grande."); }
                catch { Console.WriteLine("Ni idea de que ha pasado."); } 
            } while (!salida);

            Console.WriteLine("Pulsa una tecla para salir....");
            Console.ReadKey();
        }
    }
}
