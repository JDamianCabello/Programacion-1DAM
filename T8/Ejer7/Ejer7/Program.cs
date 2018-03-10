using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 2)
                Console.WriteLine("Este programa necesita dos parámetros!");
            else
            {
                if(!File.Exists(args[0]) || !File.Exists(args[1]))
                    Console.WriteLine("Alguna de las rutas no existe.");
                else
                {
                    File.AppendAllText(args[0], " " +File.ReadAllText(args[1]));
                }
            }
        }
    }
}
