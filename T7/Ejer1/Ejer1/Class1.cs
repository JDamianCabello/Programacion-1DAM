using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1
{
    public class Menu
    {
        string _titulo;
        string[] _opciones;
        string _pie;
        int _largoMax;

        public Menu(string titulo, string[] opciones, string pie)
        {
            
            this._titulo = titulo;
            this._opciones = opciones;
            this._pie = pie;
            _largoMax = ObtenerMaxLargo(titulo, opciones, pie);
            
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


            Console.ReadKey();
        }

        public void PintaBorde(TipoMarco tipoMarco)
        {
            Marco unMarco = new Marco(tipoMarco, _opciones.Length, _largoMax, _pie != "");
 
        }

        private int ObtenerMaxLargo (string titulo, string[] opciones, string pie)
        {
            int aux = pie.Length > titulo.Length ? pie.Length : titulo.Length;

            for (int i = 0; i < opciones.Length; i++)
			    if(opciones[i].Length > aux)
                    aux = opciones[i].Length;

            return aux;

        }
    }

    public enum TipoMarco {Simple};

    class Marco
    {
        public Marco(TipoMarco unTipoMarco, int largoMax,int totalOpciones, bool pie)
        {
            switch(unTipoMarco)
            {
                case TipoMarco.Simple:
                    TSimple(largoMax,totalOpciones,pie);
                    break;
                default:
                    break;
            }
        }

        private void TSimple(int largo, int totalOpciones, bool pie)
        {
            const string ESQUINA = "+";
            const string VERTICAL = "|";
            const string HORIZONTAL = "-";
            int total = pie ? totalOpciones + 2 : totalOpciones + 1;

            for(int i = 0; i < total; i++)
            {
                for(int j = 0; j < largo + 3; j++)
                {
                    if(i == 0 && j == 0 || i == 0 && j == largo || i == totalOpciones && j == 0 || i == totalOpciones && j == largo)
                        Console.Write(ESQUINA);
                    else if(i == 0 || i == total)
                        Console.Write(HORIZONTAL);
                    else if(j == 0 || j == largo)
                        Console.Write(VERTICAL);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }


    }
}
