using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejer1;

namespace PruebaDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            string titulo = "Un fucking menú";
            string[] opciones = { "opcion1", "opcion2", "opcion3", "opcion4", "opcion5", "opcion6" };
            string pie = "Un fucking pie";

            Menu unMenu = new Menu(titulo,opciones,pie);

            unMenu.Escribe();
            unMenu.PintaBorde(TipoMarco.Simple);
        }
    }
}
