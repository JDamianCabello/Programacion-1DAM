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

        public Menu(TipoEscritura tipo, string titulo, string[] opciones, string pie)
        {
            
            this._titulo = titulo;
            this._opciones = opciones;
            this._pie = pie;
            
        }
        public Menu()
        {
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

        public void PintaBorde(TipoMarco tipoMarco)
        {
            Marco unMarco = new Marco(tipoMarco);
 
        }

        private int ObtenerMaxLargo (string titulo, string[] opciones, string pie)
        {
            int aux = pie.Length > titulo.Length ? pie.Length : titulo.Length;

            for (int i = 0; i < opciones.Length; i++)
			    if(opciones[i].Length > aux)
                    aux = opciones[i].Length;

            return aux - 1;

        }

        private int ObtenerMaxAncho(string titulo, string[] opciones, string pie)
        {
            int aux = 2; //Se inicializa en uno debido a que siempre hay titulo y pie.

            aux += opciones.Length;

            return aux + 1;

        }
    }
}
