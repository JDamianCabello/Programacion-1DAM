using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactorialIterativo(15));
            Console.ReadLine();
        }

        static double FactorialIterativo(int n)
        {
            int aux = 1;
            for(int i = n; i > 0; i--)
                aux *= i;
            return aux;
        }
    }
}
