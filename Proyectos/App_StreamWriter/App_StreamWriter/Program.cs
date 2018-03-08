using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"c:\basura\StreamWriter.txt";
            string cadena = "Esto es una cadena de texto";
            char[] array = "Esto es un array".ToCharArray();

            //abro el fichero
            FileStream fs = new FileStream(ruta, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);

            for(int i = 1; i < 1000; i++)
                sw.WriteLine("Línea: " + i.ToString("000"));

            sw.Write(array);
            sw.Close();

            Console.WriteLine("\n\nSe ha guardado los datos del fichero....");
        }
    }
}
