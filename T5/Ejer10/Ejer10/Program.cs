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
            int nivel = 10;
            int a = 35;
            int b = 0;

            Console.Write("Calculando para el nivel {0}",nivel);

            int[,] triangulo = CalcularPascal(nivel);

            for (int i = 0; i < nivel + 1; i++)
            {
                Console.SetCursorPosition(a--, b++);
                for (int j = 0; j < nivel + 1; j++)
                {
                    if (triangulo[i, j] == 0)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("{0,4}", triangulo[i, j]);
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static int[,] CalcularPascal(int nivel)
        {
            int[,] arr = new int[nivel + 1, nivel + 1];
            for (int i = 0; i < nivel + 1; i++)
            {
                for (int k = 0; k < nivel + 1; k++)
                {
                    if (k == 0)
                        arr[i, k] = 1;
                    else if (i == k) arr[i, k] = 1;
                }
            }
            for (int i = 0; i < nivel + 1; i++)
            {
                for (int k = 0; k < nivel + 1 + 1; k++)
                {
                    if (i >= 1 && i + 1 < nivel + 1 && k + 1 < nivel + 1)
                    {
                        if (arr[i, k] != 0 && arr[i, k + 1] != 0)
                            arr[i + 1, k + 1] = arr[i, k] + arr[i, k + 1];
                    }
                }
            }
            return arr;
        }
    }
}
