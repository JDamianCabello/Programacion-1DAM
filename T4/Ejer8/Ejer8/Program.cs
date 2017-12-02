using System;

namespace Ejer8
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            Console.CursorVisible = false;
            Console.WriteLine("Programa que convierte carácteres a mayúsculas. Se sale al pulsar escape.");
            do
            {
                tecla = Console.ReadKey(true);
                if(tecla.Key != ConsoleKey.Escape && (tecla.KeyChar >= 'a' && tecla.KeyChar <= 'z' || tecla.KeyChar == 'ñ'))
                    Console.WriteLine("{0} -> {1}",tecla.KeyChar,Mayus(tecla.KeyChar));
            } while(tecla.Key != ConsoleKey.Escape);
        }

        static char Mayus(char a)
        {
            if(a == 'ñ')
                return 'Ñ';
            return (char)((int)a - 32);
        }
    }
}
