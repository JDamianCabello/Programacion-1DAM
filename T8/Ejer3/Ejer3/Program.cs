using System;
using System.IO;

namespace Ejer3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || args[0] == "\\h")
                Ayuda();
            else
            {
                string[] firma = { "\n", "\n", "\n", "Fichero copiado por Ejer3. Damián Cabello" };
                string nombreFichero = "CopiaDe" + Path.GetFileNameWithoutExtension(args[0] + Path.GetExtension(args[0]));
                if (args.Length == 1 || args[1] == "")
                {
                    File.Copy(args[0], Environment.CurrentDirectory + "\\"+ nombreFichero,true);
                    File.AppendAllLines(Environment.CurrentDirectory + "\\" + nombreFichero, firma);
                }
                else
                {
                    string rutaDestino = args[1] + "\\" + nombreFichero;
                    FileStream fs = new FileStream(rutaDestino,FileMode.OpenOrCreate,FileAccess.Write);
                    fs.Dispose();
                    File.Copy(args[0], rutaDestino, true);
                    File.AppendAllLines(rutaDestino, firma);
                }
                    
                
            }
        }

        private static void Ayuda()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("\tEjer3 - programa que copia el contenido de un fichero a otro.");
            Console.WriteLine("\nSINOPSIS");
            Console.WriteLine("\tEjer3 rutaAlFicheroOrigen [rutaAlFicheroResultado]");
            Console.WriteLine("\nDESCRIPCION");
            Console.WriteLine("\tEjer3 copia un fichero a otro dado una ruta, en caso de no especificar  una segunda  ruta");
            Console.WriteLine("\tserá en el directorio de Ejer3, Si no existiese el fichero lo crearía, en caso de existir");
            Console.WriteLine("\treemplaza.");
        }
    }
}
