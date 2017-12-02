using System;

namespace Ejer14
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            if(int.TryParse(args[0], out numero))
                if(numero >= 0)
                    Console.WriteLine("La suma recursiva hasta el número {0} es: {1}", numero, SumRecursiva(numero));
                else
                    Console.WriteLine("La resta recursiva hasta el número {0} es: {1}", numero, SumRecursivaNeg(numero));
            else
                Console.WriteLine("El parámetro \"{0}\" no es válido.",args[0]);
            Console.WriteLine("Pulsa una tecla para salir.");
            Console.ReadKey();
        }

        static double SumRecursiva(int n)
        {
            if(n == 0)
                return 0;
            if(n == 1)
                return 1;
            return n + SumRecursiva(n - 1);
        }

        static double SumRecursivaNeg(int n)
        {
            if(n == 0)
                return 0;
            if(n == -1)
                return -1;
            return n + SumRecursivaNeg(n + 1);
        }
    }
}
