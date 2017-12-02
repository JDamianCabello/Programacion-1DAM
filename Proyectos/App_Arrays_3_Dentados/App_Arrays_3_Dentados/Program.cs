using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Arrays_3_Dentados
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] m = new int[2][]
            {
                new int[7],
                new int[5]
            };

            IniMAlea(m, 5);
            VerMatriz(m);
            Console.ReadKey();
        }

        static void IniMAlea(int[][] m, int maximo)
        {
            Random rnd = new Random();
            for(int i = 0; i < m.Length; i++)
                for(int j = 0; j < m[i].Length; j++)
                    m[i][j] = rnd.Next(maximo);
        }

        static void VerMatriz(int[][] m)
        {
            for(int i = 0; i < m.Length; i++)
            {
                Console.Write("M[{0}] -> ",i);
                for(int j = 0; j < m[i].Length; j++)
                    Console.Write(m[i][j] + "\t");
                Console.WriteLine();
            }
        }
    }
}
