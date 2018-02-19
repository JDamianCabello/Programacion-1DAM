using System;
//---------------------------------
using CreadoraDeMenus;

namespace Ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] opcionesPrueba = { "opcion 1", "opcion 2", "opcion 3" };
            CreaUnMenu.BucleMenuConfirmandoSalida(ConsoleKey.Escape, opcionesPrueba, 1, ConsoleColor.DarkCyan, TipoMenu.cruz, "Titulo de menú de prueba, usa escape para salir");
        }
    }
}
