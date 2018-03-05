using System;
using System.IO;

namespace Ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"../../../../_txtRelacion/txtEjer1.txt";
            Console.CursorVisible = false;
            if(!File.Exists(ruta))
                File.Create(ruta);

            Console.WriteLine("     Datos Obtenidos con la clase Path");
            Console.WriteLine("     =================================");
            Console.WriteLine("                   Raíz: {0}", Path.GetPathRoot(Path.GetFullPath(ruta)));
            Console.WriteLine("          Ruta Absoluta: {0}",Path.GetFullPath(ruta));
            Console.WriteLine("     Nombre del fichero: {0}",Path.GetFileName(ruta));
            Console.WriteLine("  Extensión del fichero: {0}",Path.GetExtension(ruta));


            Console.WriteLine("\n\n\tPulsa una tecla para salir.");
            Console.ReadKey();
        }
    }
}
