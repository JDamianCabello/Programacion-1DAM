using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1
{
    public enum TipoEscritura { Junta, Separada };
    public class Menu
    {
        string _titulo;
        string[] _opciones;
        string _pie;

        public static string EscribeTitulo(string titulo, string marco, int separacionMarco, bool mayusculas)
        {
            char[] separador = {'\n'};
            string[] aux = marco.Split(separador[0]);
            string tmp = string.Empty;
            int mitadMarco = aux.Length / 2;
            int mitadMenu = (aux[mitadMarco].Length /2) - (titulo.Length/2);

            for(int i = 0; i < aux.Length; i++)
            {
                for(int j = 0; j < aux[i].Length; j++)
                {
                    if(i == mitadMarco && j == mitadMenu)
                        tmp += "";
                }
            }

            return tmp;
        }

        public void Escribe()
        {
            Console.CursorTop = 1;
            Console.CursorLeft = 2;
            Console.WriteLine(_titulo + "\n");
            for(int i = 0; i < _opciones.Length; i++)
            {
                Console.CursorLeft = 2;
                Console.WriteLine(" [{0}] {1}", i + 1, _opciones[i]);
            }
            Console.WriteLine("\n");
            Console.CursorLeft = 2;
            Console.WriteLine(_pie);

        }

        private int ObtenerMaxLargo (string titulo, string[] opciones, string pie)
        {
            int aux = pie.Length > titulo.Length ? pie.Length : titulo.Length;

            for (int i = 0; i < opciones.Length; i++)
			    if(opciones[i].Length > aux)
                    aux = opciones[i].Length;

            return aux - 1;

        }
    }
}
