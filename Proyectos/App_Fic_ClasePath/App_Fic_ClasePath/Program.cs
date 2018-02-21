using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_Fic_ClasePath
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaFichero = @"C:\dir1\dir2\dir3\dir4\datos.dat";
            VerDatos(rutaFichero);


            //Cambiar extensión
            rutaFichero = Path.ChangeExtension(rutaFichero, "OtraExtension");
            VerDatos(rutaFichero);
            Console.ReadKey();
        }

        static void VerDatos(string ruta)
        {
            //Obtiene y muestra informacion de las rutas.

            Console.WriteLine("                        DATOS DEL FICHERO:");
            Console.WriteLine("============================================================================\n\n");
            Console.WriteLine("         Ruta y fichero origen: {0}\n",ruta);
            Console.WriteLine("                     Extensión: {0}", Path.GetExtension(ruta));
            Console.WriteLine("               Nombre completo: {0}", Path.GetFileName(ruta));
            Console.WriteLine("                   Unidaz raiz: {0}", Path.GetPathRoot(ruta));
            Console.WriteLine("          Nombre sin extensión: {0}", Path.GetFileNameWithoutExtension(ruta));

            Console.WriteLine("\n\nFin datos archivo.......");
        }
    }
}
