using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            ConsoleKeyInfo tecla;
            Console.Title = "Pulsa ESC para salir.";
            Console.CursorVisible = false;

            do
            {
                Console.BackgroundColor = (ConsoleColor)rnd.Next(1,16);
                Console.WindowHeight = rnd.Next(1, Console.LargestWindowHeight + 1);
                Console.WindowWidth = rnd.Next(1, Console.LargestWindowWidth + 1);
                Console.Clear();
                tecla = Console.ReadKey();
            } while (tecla.Key != ConsoleKey.Escape);

        }
    }
}
