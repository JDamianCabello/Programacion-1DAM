using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FORMATEANDO LA SALIDA");
            Console.WriteLine("=====================\n");
            Console.WriteLine("{0,15:D5}", 25);
            Console.WriteLine("{0,15:E}", 250000);
            Console.WriteLine("{0,15:F}", 25);
            Console.WriteLine("{0,15}", 25);
            Console.WriteLine("{0,15}", 2.5);
            Console.WriteLine("{0,15:N}", 2500000);
            Console.WriteLine("{0,15:X}", 250);
            Console.ReadKey();
        }
    }
}
