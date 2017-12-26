using System;

namespace Ejer6
{
    class NumeroDniNoValidoException : Exception { }
    class Program
    {
        static void Main(string[] args)
        {
            int dni = 0;
            bool bandera = true;
            Console.WriteLine("Programa que devulve la letra de un DNI");
            do
            {
                Console.Write("Introduce un número: ");
                try
                {
                    dni = int.Parse(Console.ReadLine());
                    if (dni > 99999999 || dni < 10000000)
                        throw new NumeroDniNoValidoException();
                    Console.WriteLine("El DNI completo es: ");
                    Console.Write(dni + " " + LetraDNI(dni));
                    bandera = false;
                }
                catch (NumeroDniNoValidoException) { Console.WriteLine("ERROR: El número de DNI está inventado"); }
                catch (FormatException) { Console.WriteLine("ERROR: El número de DNI no es válido"); } 
            } while (bandera);

            Console.WriteLine("Pulsa una tecla para salir....");
            Console.ReadKey();
        }

        static char LetraDNI(int numero)
        {
            const string LETRAS = "TRWAGMYFPDXBNJZSQVHLCKE";
            return LETRAS[numero % 23];
        }
    }
}
