using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_SubArrayCircular
{
    class Program
    {
        static void Main(string[] args)
        {
            int limite = 12;
            int[] vector = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int posIni = 2;     //Posición inicial del subarray
            int posFin = 4;
            int indice = 0;
            int tamanoSub = posFin - posIni + 1;

            for(int i = 0; i < limite; i++)
            {
                indice = (i % tamanoSub) + posIni;
                Console.Write("[{0,2}]", vector[indice]);
            }

            Console.ReadKey();
        }
    }
}
