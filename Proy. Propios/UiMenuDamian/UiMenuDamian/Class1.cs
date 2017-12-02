using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiMenuDamian
{
        public class UImenu
        {
            public enum _tipoTitulo { simple, doble, basico, recuadroDoble};

            public UImenu(_tipoTitulo tipoTitulo, string[] opciones)
            {
                Console.CursorVisible = false;;
                EscribeTitulo(tipoTitulo,'=',"       MENU PRINCIPAL");
                EscribeOpciones(opciones, pinta);
            }


            public UImenu(_tipoTitulo tipoTitulo, char barra, string titulo, string[] opciones, ConsoleColor colorOpcion, bool cursor)
            {
                PintaOpcion pinta = new PintaOpcion(opciones, colorOpcion);
                Console.CursorVisible = cursor;
                EscribeTitulo(tipoTitulo, barra, titulo);
                EscribeOpciones(opciones, pinta);
            }


            static void EscribeTitulo(_tipoTitulo tipo, char barra,string titulo)
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
                        auxiliar = auxiliar.PadRight(titulo.Length+1, '═');
                        Console.WriteLine("╔{0}╗",auxiliar);
                        Console.WriteLine("║ {0} ║",titulo);
                        Console.WriteLine("╚{0}╝",auxiliar);
                        break;
                }
            }

            static void EscribeOpciones(string[] opciones, CambiaOpcion opcionMarcada)
            {
                for(int i = 1; i < opciones.Length; i++)
                if(Convert.ToInt32(opcionMarcada) == i)
                {
                    Console.ForegroundColor = pinta.Color;
                    Console.WriteLine("{0,2}. {1}", i, opciones[i]);
                    Console.ResetColor();
                }
                else
                    Console.WriteLine("{0,2}. {1}", i, opciones[i]);
            }
 
        }
        class CambiaOpcion
        {
            public CambiaOpcion(ConsoleKeyInfo tecla, int posicionActual, int TotalOpciones)
            {
                SeProduceCambio(tecla, posicionActual, TotalOpciones);
            }
            public static int SeProduceCambio(ConsoleKeyInfo tecla, int posicionActual, int TotalOpciones)
            {
                if(tecla.Key == ConsoleKey.UpArrow)
                    if(posicionActual == 1)
                        return posicionActual = 1;
                    else
                        return posicionActual--;
                if(tecla.Key == ConsoleKey.DownArrow)
                    if(posicionActual == TotalOpciones)
                        return TotalOpciones;
                    else
                        return posicionActual++;
                return 0;
            }
        }

}
