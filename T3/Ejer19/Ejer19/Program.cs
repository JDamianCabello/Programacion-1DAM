using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer19
{
    class Program
    {
        static void Main(string[] args)
        {
            double millas = 0;
            Console.WriteLine("Conversor de millas a metros.");
            Console.Write("Introduce el total de millas: ");
            millas = double.Parse(Console.ReadLine());
            Console.WriteLine("\n\n{0} millas marinas son {1} metros.",millas,millas*1823);
            Console.WriteLine("Pulsa una tecla para salir.");
            Console.ReadKey();
        }
    }
}
