using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer16
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static double PotenciaRecursiva(uint baase, int exponente)
        {
            if (exponente == 0)
                return 1;
            return baase * PotenciaRecursiva(baase, exponente - 1);
        }

        static double PotenciaRecursivaNeg(Double baase, int exponente)
        {
            if(exponente == 0)
                return 1;
            return PotenciaRecursivaNeg(baase, exponente + 1) / baase;
        }
    }
}
