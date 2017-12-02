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
            int anno = 0;
            Console.WriteLine("Programa que dice si un año es bisiesto o no. Introduce un valor negativo para salir.");
            do
            {
                try
                {
                    anno = int.Parse(Console.ReadLine());
                    if (EsBisiesto(anno))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("El año {0} es bisiesto.", anno);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("El año {0} no es bisiesto.", anno);
                    }
                    Console.ResetColor();
                }
                catch (FormatException) { Console.WriteLine("Error de formato."); }
                catch (ArgumentException) { Console.WriteLine("No se introdujo nada."); }
                catch (OverflowException) { Console.WriteLine("Número negativo o demasiado grande."); }
                catch { Console.WriteLine("Ni idea de que ha pasado."); }
            } while (!(anno < 0));
        }

        static bool EsBisiesto(int año)
        {
            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
                return true;
            return false;
        }
    }
}
