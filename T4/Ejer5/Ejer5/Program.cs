using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 8; i <= 64; i+=8)
                Console.WriteLine("Posicion [{0,2}]:\tValor: {1}",i, Math.Pow(2,i));
            Console.WriteLine("Pulsa una tecla para salir.");
            Console.ReadKey();
   
        }
    }
}
