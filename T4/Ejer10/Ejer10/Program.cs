using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer10
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static Double Absoluto(Double numero)
        {
            if (numero < 0)
                return numero *= -1;
            return numero;
        }
    }
}
