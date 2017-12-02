using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_13
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            do
            {
                CambiaColor();
                IUMenu();
                tecla = Console.ReadKey();
            } while (tecla.Key != ConsoleKey.D0);

        }

        static void CambiaColor()
        {
            ConsoleColor colorLetra = 0;
            ConsoleColor colorFondo = 0;
            Random rnd = new Random();
            colorLetra = (ConsoleColor)rnd.Next(16);
            colorFondo = (ConsoleColor)rnd.Next(16);
            while (colorLetra == colorFondo)
                colorFondo = (ConsoleColor)rnd.Next(16);
            Console.ForegroundColor = colorLetra;
            Console.BackgroundColor = colorFondo;
        }


        static void IUMenu()
        {
            const int POSX = 10;
            const int POSY = 5;
            Console.Clear();
            Console.SetCursorPosition(POSX, POSY);
            Console.WriteLine("MENU PRINCIPAL");
            Console.SetCursorPosition(POSX, POSY+1);
            Console.WriteLine("----------------");
            Console.SetCursorPosition(POSX, POSY+2);
            Console.WriteLine("1.\t Alta");
            Console.SetCursorPosition(POSX, POSY+3);
            Console.WriteLine("2.\t Baja");
            Console.SetCursorPosition(POSX, POSY+4);
            Console.WriteLine("3.\t Consulta");
            Console.SetCursorPosition(POSX, POSY+5);
            Console.WriteLine("4.\t Modifica");
            Console.SetCursorPosition(POSX, POSY+8);
            Console.WriteLine("0.\t Salir");
            Console.SetCursorPosition(POSX, POSY + 9);
            Console.Write("\t\tElige una opción: ");
            Console.SetCursorPosition(POSX, POSY + 12);
            Console.Write("Nota: Si pulsas un botón que no sea 0 cambia aleatoriamente de color, con 0 se sale.");
            Console.SetCursorPosition(POSX + 32, POSY + 9);
        }
    }
}
