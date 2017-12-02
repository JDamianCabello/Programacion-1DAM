using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            do
            {
                UIMenu();
                tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    case ConsoleKey.D1:
                        AreaCuadrado();
                        break;
                    case ConsoleKey.D2:
                        AreaRectangulo();
                        break;
                    case ConsoleKey.D3:
                        AreaTriangulo();
                        break;
                    default:
                        Console.CursorTop = 22;
                        Console.CursorLeft = 67;
                        Console.Write(" ");
                        break;
                }
            } while (tecla.Key != ConsoleKey.Escape);
        }

        static void UIMenu()
        {
            string[] menu = { "╔═══════════════════════╗", "║ MENÚ CALCULO DE AREAS ║", "╠═════╦═════════════════╣", "║  1  ║ Área Cuadrado   ║", "╠═════╬═════════════════╣", "║  2  ║ Área Rectángulo ║", "╠═════╬═════════════════╣", "║  3  ║ Área Triángulo  ║", "╠═════╬═════════════════╣", "║ ", "Esc", " ║ ", "Salir", "           ║", "╚═════╩═════════════════╝" };

            Console.Title = "MENU PRINCIPAL";
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < menu.Length; i++)
            {
                if(i<10)
                    Console.SetCursorPosition(45, 10 + i);
                if(i==menu.Length-1)
                    Console.SetCursorPosition(45, 10 + i - 4);
                if (i >= 9 && i < menu.Length-2)
                {
                    if (menu[i] == "Esc" || menu[i] == "Salir")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(menu[i]);
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    else
                    Console.Write(menu[i]);
                }
                else
                    Console.WriteLine(menu[i]);
            }
            Console.CursorVisible = false;
            Console.ResetColor();
            Console.CursorTop = 22;
            Console.CursorLeft = 50;
            Console.Write("Elige una opción.");
        }

        static void AreaCuadrado()
        {
            Console.Title = "AREA CUADRADO";
            Console.CursorVisible = true;
            double lado = 0;
            Console.Clear();
            Console.WriteLine("Menú de área de cuadrado.");
            Console.WriteLine("=========================");
            Console.Write("\nIntroduce el valor del lado: ");
            if(double.TryParse(Console.ReadLine(),out lado))
                Console.WriteLine("\nEl área de un cuadrado de lado {0} es {1:F2}", lado, Math.Pow(lado, 2));
            else
                Console.WriteLine("El valor introducido no es correcto.");
            Console.WriteLine("\nPulsa una tecla para volver al menú.");
            Console.ReadKey();
        }

        static void AreaTriangulo()
        {
            Console.Title = "AREA TRIANGULO";
            Console.CursorVisible = true;
            double basee = 0;
            double altura = 0;
            Console.Clear();
            Console.WriteLine("Menú de área de triángulo.");
            Console.WriteLine("=========================");
            Console.Write("\nIntroduce el valor de la base: ");
            basee = double.Parse(Console.ReadLine());
            Console.Write("\nIntroduce el valor de la altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEl área de un triángulo de base {0} y altura {1} es {2:F2}", basee, altura,basee*altura/2);
            Console.WriteLine("\nPulsa una tecla para volver al menú.");
            Console.ReadKey();
        }

        static void AreaRectangulo()
        {
            Console.Title = "AREA RECTANGULO";
            Console.CursorVisible = true;
            double basee = 0;
            double altura = 0;
            Console.Clear();
            Console.WriteLine("Menú de área del rectángulo.");
            Console.WriteLine("=========================");
            Console.Write("\nIntroduce el valor de la base: ");
            basee = double.Parse(Console.ReadLine());
            Console.Write("\nIntroduce el valor de la altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEl área de un rectángulo de base {0} y altura {1} es {2:F2}", basee, altura, basee * altura);
            Console.WriteLine("\nPulsa una tecla para volver al menú.");
            Console.ReadKey();
        }
    }
}
