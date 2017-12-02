using System;

namespace Ejer8
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numero = 0;
            byte contador = 0;
            byte numIntroducido = 0;
            Console.WriteLine("Adivina el número.");
            Console.WriteLine("Introduce el número que deberá buscar tu compañero. (entre 1 y 100, si es menor se asigna 1 y si es mayor 100)");
            if(byte.TryParse(Console.ReadLine(), out numero))
            {
                if(numero <= 0)
                    numero = 1;
                if(numero > 100)
                    numero = 100;
                Console.Clear();
                while(numIntroducido != numero)
                {
                    Console.Write("Introduce un número: ");
                    if(byte.TryParse(Console.ReadLine(), out numIntroducido))
                    {
                        if(numIntroducido > numero)
                            Console.WriteLine("El numero que buscas es MENOR al introducido");
                        if(numIntroducido < numero)
                            Console.WriteLine("El numero que buscas es MAYOR al introducido");
                        contador++;  
                    }
                    else
                        Console.WriteLine("Número no válido.");

                }
                Console.WriteLine("Acertaste el número en {0} intentos",contador);
                Console.WriteLine("Pulsa una tecla para salir.");
                Console.ReadKey();
            }
            else
                Console.WriteLine("El número no es válido.");
        }
    }
}
