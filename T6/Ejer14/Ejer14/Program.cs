using System;
using System.Collections.Generic;

namespace Ejer14
{
    class Program
    {
        static Dictionary<char, int> dicionario = new Dictionary<char, int>();

        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            Console.WriteLine("Programa que cuenta las letras dadas en una frase.");
            Console.Write("Introduce tu frase: ");
            do
            {
                tecla = Console.ReadKey();
                CuentaLetras(tecla.KeyChar);
            } while (!(tecla.Modifiers == (ConsoleModifiers.Control) && tecla.Key == ConsoleKey.Z));

            Console.WriteLine("\n\n\n");
            Estadisticas();


            Console.WriteLine("\n\nPulsa enter para salir.....");
            Console.ReadLine();
        }


        static void CuentaLetras(char tecla)
        {
            if (char.IsLetter(tecla))
            {
                if (dicionario.ContainsKey(tecla))
                {
                    dicionario[tecla] += 1;
                }
                else
                    dicionario.Add(tecla, 1); 
            }
        }

        static void Estadisticas()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ESTADISTICAS:\n");
            Console.ResetColor();

            List<char> miLista = new List<char>();

            foreach (var item in dicionario)
                miLista.Add(item.Key);

            miLista.Sort();
            Console.Write(" ");
            foreach (var item in miLista)
                Console.Write(item.ToString() + "  ");

            Console.WriteLine("\n" + "-".PadRight(80,'-') + "\n");

            foreach (var item in miLista)
                Console.Write(dicionario[item] + "  ");


        }
    }
}
