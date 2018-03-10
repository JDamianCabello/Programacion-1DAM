using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3 || args[0] =="\\h")
                Ayuda();
            else
            {
                string nombreFichero = Path.GetFileNameWithoutExtension(args[0]) + "_Omitiendo " + Char.ToUpper(args[2][0]) + "_"+ Path.GetExtension(args[0]);
                string rutaDestino = args[1] + "\\" + nombreFichero;
                string texto = File.ReadAllText(args[0]);
                texto = texto.Replace(args[2][0].ToString(), string.Empty);
                FileStream fs;
                if (!File.Exists(args[1]))
                    fs = new FileStream(rutaDestino, FileMode.OpenOrCreate, FileAccess.Write);
                else
                    fs = new FileStream(rutaDestino, FileMode.Truncate, FileAccess.Write);

                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(texto);

                sw.Dispose();
                fs.Dispose();

                Console.WriteLine("Se copio corectamente!");


            }
        }

        private static void Ayuda()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("\tEjer4 - programa que copia el contenido de un fichero a otro omitiendo un caracter");
            Console.WriteLine("\nSINOPSIS");
            Console.WriteLine("\tEjer3 rutaAlFicheroOrigen rutaAlFicheroResultado caracterAOmitir");
            Console.WriteLine("\nDESCRIPCION");
            Console.WriteLine("\tEjer4 copia un fichero a otro dado una ruta y un caracter el cual será ignorado a la hora");
            Console.WriteLine("\tde copiar, el nombre del fichero será el mismo del de la copia añadiendo omitiendo X char");
            Console.WriteLine("\teste programa reemplaza siempre y no pide confirmación para ello.");
        }
    }
}
