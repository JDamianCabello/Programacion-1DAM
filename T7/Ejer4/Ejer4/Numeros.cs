using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4
{
    class Numeros
    {
        public static double FactorialRecursivo(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            else
            {
                return n * FactorialRecursivo(n - 1);
            }
        }

        public static double FactorialIterativo(int n)
        {
            double resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;

        }

        public static int FibonacciRecursiva(int n)
        {
            if (n == 0)
            {
                return 1; 
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return FibonacciRecursiva(n - 1) + FibonacciRecursiva(n - 2);
            }

        }

        public static int FibonacciIterativo(int n)
        {
            int[] f = new int[3];
            f[0] = 1;
            f[1] = 1;

            if (n == 0)
            {
                return 1; 
            }
            else if (n == 1)
            {
                return 1;
            }

            for (int i = 2; i < n + 1; i++)
            {
                f[2] = f[1] + f[0];
                f[0] = f[1];
                f[1] = f[2];
            }
            return f[2];
        }

        public static int SumaIterativa(int n)
        {
            int resultado = 0;

            for (int i = 1; i <= n; i++)
            {
                resultado += i;
            }

            return resultado;
        }

        public static int SumaRecursiva(int n)
        {
            if (n == 1)
                return 1;
            return n + SumaRecursiva(n - 1);
        }


        public static bool EsPrimo(int numero)
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
