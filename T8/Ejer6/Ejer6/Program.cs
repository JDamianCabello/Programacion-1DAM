using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejer6
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 2)
                Console.WriteLine("Error de argumentos (cero o más de dos)");
            else if(!File.Exists(args[1]))
                Console.WriteLine("El archivo no existe!");
            else
            {
                int contador = 0;
                string texto = File.ReadAllText(args[1],Encoding.Default);

                foreach(var item in texto)
                    if(args[0][0] == item)
                        contador++;


                Console.WriteLine("El caracter \"{0}\" aparece {1} vez/veces",args[0],contador);
            }
        }
    }
}
