using System;
using System.Text;
using System.IO;

namespace Ejer5
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0 || args.Length > 1)
                Console.WriteLine("No se especificó la ruta correctamente (cero o más de un argumentos).");
            else if(!File.Exists(args[0]))
                Console.WriteLine("No existe el archivo!");
            else
            {
                string[] texto = File.ReadAllLines(args[0],Encoding.Default);
                foreach(var item in texto)
                    Console.WriteLine(item);
            }
        }



    }
}
