using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_NumerosMath
{
    class Program
    {
        static void Main(string[] args)
        {
            double dobleMayor = 3.71;
            double dobleMenor = 3.22;
            Console.WriteLine("Ceiling de {0} -> {1}",dobleMayor,Math.Ceiling(dobleMayor));
            Console.WriteLine("Ceiling de {0} -> {1}", dobleMenor, Math.Ceiling(dobleMenor));

            Console.ReadKey();
        }
    }
}
