using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecu1TrimResuelto
{
    class Program
    {
        static void Main(string[] args)
        {
            UIMenu();
        }

        static void UIMenu()
        {
            ConsoleKeyInfo tecla;
            Console.CursorVisible = false;

            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Examen recuperación 1er Trimestre resuelto.\n\n");
                    Console.WriteLine("{0}     {1}     {2}", "Cabello", "Juan Damián", DateTime.Now.ToShortDateString());
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("\tA. Encriptación Cesar");
                    Console.WriteLine("\tB. Matriz de referencia");
                    Console.WriteLine("\tC. Cálculo de salarios");
                    Console.Write("\tS. ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Salir");
                    Console.ResetColor();
                    tecla = Console.ReadKey(true);

                    switch(tecla.Key)
                    {
                        case ConsoleKey.A:
                            Cesar();
                            break;
                        case ConsoleKey.B:
                            break;
                        case ConsoleKey.C:
                            break;
                        default:
                            break;
                    }
                } while(tecla.Key != ConsoleKey.S);
                Console.Clear();
                Console.WriteLine("Seguro que quieres salir? S/n");
                tecla = Console.ReadKey(true);
            } while(tecla.Key != ConsoleKey.S);

        }

        static void Cesar()
        {
            ConsoleKeyInfo tecla;
            string frase = string.Empty;
            string cesar = string.Empty;
            Console.Clear();
            Console.WriteLine("Programa que escribe una frase encriptada.");
            Console.WriteLine("Solo son válidos los números.");
            do
            {
                Console.SetCursorPosition(frase.Length, 3);
                tecla = Console.ReadKey();
                frase += tecla.KeyChar;
                if(Char.IsDigit(tecla.KeyChar))
                {
                    cesar += (char)((tecla.KeyChar + 5) % 10);
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("Frase encriptada: {0}", cesar);
                }

            } while(tecla.Key != ConsoleKey.Escape);

        }
    }
}
