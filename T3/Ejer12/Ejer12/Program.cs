using System;

namespace Ejer12
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Programa que dado un número menor que 10000 escribe todos los primos hasta ese número.");
            Console.WriteLine("Dame el número entre 0 y 10000: ");
            total = int.Parse(Console.ReadLine());
            if(total<1 || total>10000)
                Console.WriteLine("Número fuera de los rangos permitidos.");
            else
            {
                for (int i = 0; i <= total; i++)
                    if(EsPrimo(i))
                        Console.Write("{0,4},\t",i);
                Console.WriteLine("\n\nPulsa una tecla para salir.");
                Console.ReadKey();
            }
        }


        static bool EsPrimo(int numero)
        {
            if(numero <= 1)
                return false;
            for(int i = 2; i < numero / 2; i++)
                if(numero % i == 0)
                    return false;
            return true;
        }
    }
}
