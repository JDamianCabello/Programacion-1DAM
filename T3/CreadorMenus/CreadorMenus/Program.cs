using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreadorMenus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }

    public class CreadorDeMenus
    {
        public enum _tipoTitulo { simple, doble, basico, recuadroDoble };





 
    }

    class EscribeMenu
    {
        enum _tipoTitulo { simple, doble, basico, recuadroDoble };

        public EscribeMenu(_tipoTitulo tipo, char caracterBarra, string tiulo)
        { 

        }


        static void EscribeTitulo(_tipoTitulo tipo, char barra, string titulo)
        {
            string auxiliar = string.Empty;
            switch (tipo)
            {
                case _tipoTitulo.basico:
                    auxiliar = auxiliar.PadRight(20, barra);
                    Console.WriteLine(titulo);
                    Console.WriteLine(auxiliar);
                    break;
                case _tipoTitulo.doble:
                    auxiliar = auxiliar.PadRight(20, barra);
                    Console.WriteLine(auxiliar);
                    Console.WriteLine(titulo);
                    Console.WriteLine(auxiliar);
                    break;
                case _tipoTitulo.simple:
                    Console.WriteLine(titulo);
                    break;
                case _tipoTitulo.recuadroDoble:
                    auxiliar = auxiliar.PadRight(titulo.Length + 1, '═');
                    Console.WriteLine("╔{0}╗", auxiliar);
                    Console.WriteLine("║ {0} ║", titulo);
                    Console.WriteLine("╚{0}╝", auxiliar);
                    break;
            }
        }

        static void EscribeOpciones(string[] opciones, int opcionMarcada,ConsoleColor color)
        {
            for (int i = 1; i < opciones.Length; i++)
                if (Convert.ToInt32(opcionMarcada) == i)
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine("{0,2}. {1}", i, opciones[i]);
                    Console.ResetColor();
                }
                else
                    Console.WriteLine("{0,2}. {1}", i, opciones[i]);
        }
    }

}
