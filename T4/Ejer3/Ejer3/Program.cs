using System;


namespace Ejer3
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numero = 0;
            Console.WriteLine("Programa que dice si un número positivo es primo o no. Se sale con 0.");
            do
            {
                Console.Write("Introduce un número: ");
                try
                {
                    numero = uint.Parse(Console.ReadLine());
                }
                catch (FormatException) { Console.WriteLine("Error de formato."); }
                catch (ArgumentException) { Console.WriteLine("No se introdujo nada."); }
                catch (OverflowException) { Console.WriteLine("Número negativo o demasiado grande."); }
                catch { Console.WriteLine("Ni idea de que ha pasado."); }
                if (EsPrimo(numero))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("El número {0} es primo.", numero);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El número {0} no es primo.", numero);
                }
                Console.ResetColor();
            } while (numero != 0);
        }

        static bool EsPrimo(uint numero)
        {
            if (numero <= 1)
                return false;
            for (int i = 2; i < numero / 2; i++)
                if (numero % i == 0)
                    return false;
            return true;
        }
    }
}
