using System;
using System.IO;

namespace Ejer9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] archivos;
            FileInfo fi;


            if (Directory.Exists(args[0]))
            {
                archivos = Directory.GetFiles(args[0]);
                for (int i = 0; i < archivos.Length; i++)
                {
                    fi = new FileInfo(archivos[i]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Mostrando el archivo: " + fi.Name);
                    Console.WriteLine("".PadRight(Console.WindowWidth - 1, '='));
                    Console.ResetColor();
                    Console.WriteLine(File.ReadAllText(archivos[i]));
                    Console.WriteLine("Fin de archivo............");
                }
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    fi = new FileInfo(args[i]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Mostrando el archivo: " + fi.Name);
                    Console.WriteLine("".PadRight(Console.WindowWidth - 1, '='));
                    Console.ResetColor();
                    Console.WriteLine(File.ReadAllText(args[i]));
                    Console.WriteLine("Fin de archivo............");
                }
            }
        }
    }
}
