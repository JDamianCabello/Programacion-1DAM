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
            List<ICarrera> unaCarrera = new List<ICarrera>();
            Random rnd = new Random();

            for(int i = 0; i < 30; i++)
            {
                if(rnd.Next(0, 2) == 1)
                    unaCarrera.Add(new Coche());
                else
                    unaCarrera.Add(new Deportista());
                System.Threading.Thread.Sleep(5);
            }

            foreach(ICarrera unItem in unaCarrera)
            {
                if(unItem is Coche)
                    Console.ForegroundColor = ConsoleColor.White;
                else
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                unItem.Correr();
            }
            Console.ResetColor();

            Console.WriteLine("\n\n\nPulsa una tecla para salir....");
            Console.ReadKey();

        }
    }
}
