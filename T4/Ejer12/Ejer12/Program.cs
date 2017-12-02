using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer12
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static double FactorialRecursivo(Double numero)
        {
            if (numero == 0)
                return 1;
            return numero * FactorialRecursivo(numero - 1);
        }
    }
}
