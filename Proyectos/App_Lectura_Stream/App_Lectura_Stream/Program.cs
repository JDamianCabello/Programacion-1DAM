using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_Lectura_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = "c:\\basura\\entrada.txt";

            Listar(ruta);

            Console.ReadKey();
        }


        static void Listar(string ruta)
        {
            FileStream fs = new FileStream(ruta, FileMode.Open);

            int caracter;

            while((caracter = fs.ReadByte()) != -1)//OJO! esto solo es aplicable a clases que leen texto pues no hay ASCII negativos pero bytes negativos s.
                Console.Write((char)caracter);

            fs.Dispose();
        }
    }
}
