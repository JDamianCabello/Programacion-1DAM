using System;
using System.IO;

namespace Ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            DirectoryInfo carpeta = new DirectoryInfo(@"../../../../_txtRelacion/");

            if(!carpeta.Exists)
                carpeta.Create();

            Console.WriteLine("     Datos Obtenidos con la clase Path");
            Console.WriteLine("     =================================");
            Console.WriteLine("                    Ruta: {0}", carpeta.FullName);
            Console.WriteLine("Atributos del directorio: {0}", carpeta.Attributes);
            Console.WriteLine("   Nombre del directorio: {0}",carpeta.Name);
            Console.WriteLine("\n\n\tFicheros en el directorio:");

            FileInfo[] ficheros = carpeta.GetFiles();
            for(int i = 0; i < ficheros.Length; i++)
                Console.WriteLine("\t{{{0,2}}}\t{1}",i+1,ficheros[i].Name);


            Console.WriteLine("\n\n\tPulsa una tecla para salir.");
            Console.ReadKey();
        }
    }
}
