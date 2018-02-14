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
            string[] opciones = { "opcion1", "opcion2", "opcion3", "opcion4", "opcion5", "opcion6","1234567890123456789" };
            string pie = "Un fucking pie";

            //Menu unMenu = new Menu(TipoEscritura.Separada, titulo,opciones,pie);

            //unMenu.Escribe();
            //unMenu.PintaBorde(TipoMarco.Simple);

            Console.Clear();
            //Console.WriteLine(Marco.PintaRecuadro('*', '.',3,40,1));
            Console.WriteLine(Marco.PintaRecuadro('*', '.','@', 3, 25, 1));

            Console.WriteLine(Marco.PintaRecuadro('*',' ','q','w','e','r',3,5,1));

            Console.WriteLine(Marco.PintaRecuadro('-','|',' ','+',3,25,1));

            Console.WriteLine(Marco.PintaRecuadro(3,'*'));
            Console.WriteLine(Marco.RecuadrosPorDefecto(TipoMarco.Básico, 3));
            Console.WriteLine(Marco.RecuadrosPorDefecto(TipoMarco.Cruz,3));
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(Marco.RecuadrosPorDefecto(TipoMarco.Simple, 3));
            Console.ResetColor();
            Console.WriteLine(Marco.RecuadrosPorDefecto(TipoMarco.Doble,3));


            Console.ReadKey();
        }
    }
}
