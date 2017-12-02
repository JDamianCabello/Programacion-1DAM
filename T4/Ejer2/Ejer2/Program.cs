using System;

namespace Ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter = ' ';
            int totalVeces = 0;
            Console.WriteLine("Programa que muestra un caracter tantas veces como se le indique.");
            Console.Write("Dime el caracter: ");
            caracter = (char)Console.Read();
            Console.ReadLine();
            do
            {
                Console.WriteLine("Dime el total de veces que se repetirá: ");
            } while(!int.TryParse(Console.ReadLine(), out totalVeces));
            Console.WriteLine(EscribeLetra(caracter,totalVeces));
            Console.WriteLine("Pulsa una tecla para salir.");
            Console.ReadKey();

        }

        static private string EscribeLetra(char caracter, int totalCaracteres)
        {
            string aux = string.Empty;
            for(int i = 0; i < totalCaracteres; i++)
                aux += caracter;
            return aux;
        }
    }
}
