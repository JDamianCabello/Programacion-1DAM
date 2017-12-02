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
            Console.WriteLine(EsPrimo(int.MaxValue));

            Console.ReadKey();
        }

        static bool EsPrimo(int numero)
        {
            if(numero <= 1)
                return false;
            for(int i = 2; i < numero/2; i++)
                if(numero % i == 0)
                    return false;
            return true;
        }

    }
}
