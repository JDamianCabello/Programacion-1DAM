using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ParametrosMain
{
    class Program
    {
        static void Main(string[] args)
        {
            //mostrar información de los parámetros.

            if(args.Length == 0)
            {
                Console.WriteLine("No hay parámetros para mostrar");
                return;
            }
            //Lista de parámetros.
            Console.WriteLine("LISTA DE PARAMETROS RECIBIDOS Version: foreach");
            Console.WriteLine("==============================================");
            foreach(string tmp in args)
                Console.WriteLine(tmp);

            Console.WriteLine("LISTA DE PARAMETROS RECIBIDOS Version: for");
            Console.WriteLine("==============================================");
            for(int i = 0; i < args.Length; i++)
                Console.WriteLine("[{0}]\t\t", i, args[i]);
        }
    }
}
