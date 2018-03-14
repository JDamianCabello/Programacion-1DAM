using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer10
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
                Console.WriteLine("Solo se admite un parámetro!");
            else if (!File.Exists(args[0]))
                Console.WriteLine("El archivo no existe");
            else
            {
                char[] texto = File.ReadAllText(args[0]).ToCharArray();
                Array.Reverse(texto);
                Console.WriteLine(texto);
            }
        }
    }
}
