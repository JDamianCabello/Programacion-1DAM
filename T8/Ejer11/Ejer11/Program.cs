using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejer11
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = string.Empty;
            string todo = string.Empty;
            string ruta = @"E:\Google Drive\Git\Programacion\T8\_txtRelacion\txtEjer11.txt";
            do
            {
                Console.Clear();
                Console.WriteLine("Para salir escribe en blanco");
                Console.WriteLine("Escribe lo que quieras guardar en el fichero: ");
                texto = Console.ReadLine();
                if (texto != "")
                    todo += texto + "\n";
            } while (texto != "");
            File.AppendAllText(ruta, todo);
        }
    }
}
