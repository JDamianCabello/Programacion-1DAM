using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer21
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            do
            {
                Console.CursorVisible = false;
                Console.Clear();
                UIMenu();
                tecla = Console.ReadKey(true);
                switch(tecla.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado ALTAS.");
                        Console.WriteLine("Pulsa una tecla para volver al menu.");
                        Console.ReadKey();

                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado BAJAS.");
                        Console.WriteLine("Pulsa una tecla para volver al menu.");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("Has seleccionado MODIFICACIONES.");
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado CONSULTAS.");
                        Console.WriteLine("Pulsa una tecla para volver al menu.");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Por favor, opciones entre 1 y 4, 0 para salir.");
                        Console.WriteLine("Pulsa una tecla para volver al menu.");
                        Console.ReadKey();
                        break;
                }
            } while(tecla.Key != ConsoleKey.D0);
        }

        static void UIMenu()
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("          MENU PRINCIPAL");
            Console.WriteLine("==============================================================");
            Console.WriteLine("\n\n");
            Console.WriteLine("1.\tAltas");
            Console.WriteLine("2.\tBajas");
            Console.WriteLine("3.\tAltas");
            Console.WriteLine("4.\tConsultas");

            Console.WriteLine("\n0.\tSalir");

            Console.WriteLine("\n\nPor favor, pulsa una opción.");
        }
    }
}
