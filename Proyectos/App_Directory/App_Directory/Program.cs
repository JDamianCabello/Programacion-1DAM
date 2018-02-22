using System;
using System.IO;

namespace App_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"..\..\..\..\";
            string[] ficheros = Directory.GetDirectories(ruta);

            foreach(var item in ficheros)
                Console.WriteLine(item.Substring(12));

            Console.ReadKey();
        }
    }
}
