using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_recursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 54;
            Console.WriteLine("El factorial de 4 (cuenta la vieja es: {0}",4 * 3 * 2 * 1);
            Console.WriteLine("El factorial de  {0} recursivo es: {1}", n, FactorialRecursivo(n));
            Console.WriteLine("El factorial de  {0} iterativo es: {1}", n, FactorialIterativo(n));

            Console.ReadKey();
        }

        static double FactorialRecursivo(int numero)
        {
            return numero == 0 ? 1 : numero * FactorialRecursivo(numero-1);
            /*
            if(numero == 0)
                return 1;
            return numero * FactorialRecursivo(numero - 1);
             */
        }

        static double FactorialIterativo(int numero)
        {
            double resultado = 1;
            for(int i = 1; i <= numero; i++)
                resultado *= i;
            return resultado;
        }
    }
}
