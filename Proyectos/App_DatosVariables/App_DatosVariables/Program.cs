using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_DatosVariables
{
    class Program
    {
        static int compartir = 0;

        static void Main(string[] args)
        {
            int i = 0;
            Int16 entero16 = 0;
            Int32 entero32 = 0;
            Int64 entero64 = 0;
            char caracter = (char)65;
            byte octeto = 0;

            //Mostrar los distintos tipos
            Console.WriteLine("  TIPOS  DE  DATOS   ");
            Console.WriteLine("------------------------");
            Console.WriteLine("     Entero: {0}", i.GetType());
            Console.WriteLine("   Caracter: {0}", caracter.GetType());
            Console.WriteLine("     Octeto: {0}", octeto.GetType());
            Console.WriteLine("   Entero64: {0}", entero64.GetType());

            //Mostrar el rango máximo y mínimo de cada tipo.
            Console.WriteLine("Minimo {0}, máximo {1}",char.MinValue,char.MaxValue);
        }
    }
}
