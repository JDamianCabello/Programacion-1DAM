using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejer12
{
    /*
     * Haz un programa permita acceder, usando un componente, a un fichero de texto y cuente el número de líneas que
hay, su tamaño, sus atributos y el número de palabras, el resultado se mostrará en pantalla.
*/
    class Program
    {
        static void Main(string[] args)
        {
            if(!File.Exists(args[0]))
                Console.WriteLine("No es una ruta válida");
            else
            {
                int lineas = File.ReadAllLines(args[0]).Length;
                FileInfo fi = new FileInfo(args[0]);
                char[] separador = { ' ','\n' };
                long tamanio = fi.Length;
                int palabras = File.ReadAllText(args[0]).Split(separador, StringSplitOptions.RemoveEmptyEntries).Length;


                Console.WriteLine("        Archivo: {0}", fi.Name);
                Console.WriteLine("         Líneas: {0}",lineas);
                Console.WriteLine("      Atributos: {0}",fi.Attributes);
                Console.WriteLine("Total palabras : {0}",palabras);

                Console.ReadKey();
            }
        }
    }
}
