/*-------------------------------------------------------
 * AUTOR: Damián Cabello
 * FECHA: 09/10/17
 * VERSIÓN: 1.0
 * DESCRIPCIÓN: Ejercicio 12 de la práctica.
 *-----------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_12
{
    class Program
    {
        static void Main(string[] args)
        {
            const int POSX = 10;
            const int POSY = 5;
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
            Console.SetCursorPosition(POSX, POSY+9);
            Console.Write("\t\tElige una opción: ");
            Console.ReadKey();

        }
    }
}
