using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace App_KeyAvailable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            char caracter = '*';
            ConsoleKeyInfo tecla;
            int left = 0;
            int top = 0;
            Random random = new Random();
            int maxAnchoConsola = Console.WindowWidth;
            int maxAltoConsola = Console.WindowHeight;
            int espera = 100;

            do
            {
                left = random.Next(maxAnchoConsola);
                top = random.Next(maxAltoConsola);
                Console.SetCursorPosition(left, top);
                Console.Write(caracter);
                Thread.Sleep(espera);
            } while(!Console.KeyAvailable);

            tecla = Console.ReadKey(true);
            Console.WriteLine("Has pulsado: {0}",tecla.Key);



            Console.ReadKey();

        }
    }
}
