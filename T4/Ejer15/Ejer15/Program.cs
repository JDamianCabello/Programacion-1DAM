using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            if (int.TryParse(args[0], out numero))
                if (numero >= 0)
                    Console.WriteLine("La suma iterativa hasta el número {0} es: {1}", numero, SumIterativa(numero));
            else
                Console.WriteLine("El parámetro \"{0}\" no es válido.", args[0]);
            Console.WriteLine("Pulsa una tecla para salir.");
            Console.ReadKey();
        }

        static double SumIterativa(int n)
        {
            int aux = 0;
            for (int i = 1; i <= n; i++)
                aux += i;
            return aux;
        }


    }
}
