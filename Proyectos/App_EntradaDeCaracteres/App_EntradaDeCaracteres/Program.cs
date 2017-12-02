using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_EntradaDeCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrimerEjemplo(); primera parte del ejemplo
            string nombre = string.Empty;
            ConsoleKeyInfo pulsacion;

            do
            {
                pulsacion = Console.ReadKey();
                if(Char.IsNumber(pulsacion.KeyChar))
                    nombre += pulsacion.KeyChar;

                //Teclas muertas usadas
                if(pulsacion.Modifiers == (ConsoleModifiers.Control | ConsoleModifiers.Alt | ConsoleModifiers.Shift))
                    Console.WriteLine("Has pulsado Ctrl + Alt + Shift");

                MostrarInfoTecla(pulsacion);

            } while(pulsacion.Key != ConsoleKey.Enter);
            Console.SetCursorPosition(10,10);
            Console.WriteLine("Has introducido la frase: {0}",nombre);
            Console.ReadKey();
        }

        static private void MostrarInfoTecla(ConsoleKeyInfo tecla)
        {
            Console.WriteLine("     Caracter imprimible : {0}", tecla.KeyChar);
            Console.WriteLine("     Constante tecla     : {0}", tecla.Key);
            Console.WriteLine("     Teclas muertas      : {0}", tecla.Modifiers);
        }

        static void PrimerEjemplo()
        {
            int teclaN = 0;
            char teclaC = ' ';

            //Lecturas con read
            Console.Write("Dime un caracter: ");
            teclaN = Console.Read();
            Console.ReadLine();
            teclaC = (char)teclaN;
            Console.WriteLine("El caracter {0} tiene el ASCII {1}", teclaC, teclaN);

            Console.WriteLine("Pulsa una tecla para finalizar.");
            Console.ReadLine();
        }
    }
}
