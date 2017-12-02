using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiMenuDamian;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menu = { "op1", "op2", "op3", "op4", "salir", "op1", "op2", "op3", "op4", "salir" };
            UImenu miMenu = new UImenu(UImenu._tipoTitulo.simple, menu);
            Console.ReadKey();
        }

        /*
         * static void UIMenu(string[] opciones, int OpcionMarcada, ConsoleColor colorOpcion)
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("       MENU PRINCIPAL");
            Console.WriteLine("===============================");

            for(int i = 1; i < opciones.Length; i++)
                if(OpcionMarcada == i)
                {
                    Console.ForegroundColor = colorOpcion;
                    Console.WriteLine("{0,2}. {1}", i, opciones[i]);
                    Console.ResetColor();
                }
                else
                    Console.WriteLine("{0,2}. {1}", i, opciones[i]);

        }

        static int pintaOpcion(string[] opciones, ConsoleColor colorMarcado)
        {
            ConsoleKeyInfo tecla;
            int marcada = 1;
            do
            {
                UIMenu(opciones, marcada, colorMarcado);
                tecla = Console.ReadKey();
                if(tecla.Key == ConsoleKey.UpArrow)
                    if(marcada == 1)
                        marcada = 1;
                    else
                        marcada--;
                if(tecla.Key == ConsoleKey.DownArrow)
                    if(marcada == opciones.Length - 1)
                        marcada = opciones.Length - 1;
                    else
                        marcada++;
                if(tecla.Key == ConsoleKey.Enter)
                    return marcada - 1;
            } while(tecla.Key != ConsoleKey.Escape);

            return 0;

        }*/
       
    }
}
