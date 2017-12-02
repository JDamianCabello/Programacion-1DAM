using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_DimensionesPantalla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================");
            Console.WriteLine("    P A N T A L L A");
            Console.WriteLine("=======================\n");
            Console.WriteLine("Por defecto:");
            Console.WriteLine(" Alto actual: {0}",Console.WindowHeight);
            Console.WriteLine("Ancho actual: {0}", Console.WindowWidth);

            //Cambiar las dimensiones
            Console.WriteLine("\nCambiandola a  24 x 80");
            Console.WindowHeight = 24;
            Console.WindowWidth = 80;
            Console.WriteLine(" Alto actual: {0}", Console.WindowHeight);
            Console.WriteLine("Ancho actual: {0}", Console.WindowWidth);

            //Cambiar dimensiones al máximo
            Console.WriteLine("\nEstableciendo el máx de alto y ancho.");
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;
            Console.WriteLine(" Alto actual: {0}", Console.WindowHeight);
            Console.WriteLine("Ancho actual: {0}", Console.WindowWidth);
        }
    }
}
