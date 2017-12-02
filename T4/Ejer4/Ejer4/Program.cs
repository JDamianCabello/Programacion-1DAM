using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static bool EsPrimo(uint numero)
        {
            if (numero <= 1)
                return false;
            for (int i = 2; i < numero; i++)
                if (numero % i == 0)
                    return false;
            return true;
        }
    }
}
