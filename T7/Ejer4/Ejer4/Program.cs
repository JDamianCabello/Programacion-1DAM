using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string[] opciones = { "Factorial Recursivo", "Factorial Iterativo", "Fibonacci Recursivo", "Fibonacci Iterativo", "Suma Iterativa", "Suma Recursiva", "Es Primo", "Salir" };
            bool salida = true;
            do
            {
                switch (CreadoraDeMenus.CreaUnMenu.BucleMenuConfirmandoSalida(ConsoleKey.Escape, opciones, 1, ConsoleColor.DarkGreen, CreadoraDeMenus.TipoMenu.recuadroDoble, "Menú de prueba de la clase números"))
                {
                    case 0: //Factorial Recursivo
                        Console.Clear();
                        Console.WriteLine("Hago el Factorial Recursivo.");
                        Console.Write("Escriba un número: ");
                        numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("EL resultado es: {0}", Numeros.FactorialRecursivo(numero));
                        Console.ReadLine();
                        break;

                    case 1: //Factorial Iterativo
                        Console.Clear();
                        Console.WriteLine("Hago el Factorial Iterativo.");
                        Console.Write("Escriba un número: ");
                        numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("EL resultado es: {0}", Numeros.FactorialIterativo(numero));
                        Console.ReadLine();
                        break;

                    case 2: //Fibonacci Recursivo
                        Console.Clear();
                        Console.WriteLine("Hago el Fibonacci Recursivo.");
                        Console.Write("Escriba un número: ");
                        numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("EL resultado es: {0}", Numeros.FibonacciRecursiva(numero));
                        Console.ReadLine();
                        break;

                    case 3: //Fibonacci Iterativo
                        Console.Clear();
                        Console.WriteLine("Hago el Fibonacci Iterativo.");
                        Console.Write("Escriba un número: ");
                        numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("EL resultado es: {0}", Numeros.FibonacciIterativo(numero));
                        Console.ReadLine();
                        break;

                    case 4: //Suma Iterativa
                        Console.Clear();
                        Console.WriteLine("Hago la Suma Iterativa.");
                        Console.Write("Escriba un número: ");
                        numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("EL resultado es: {0}", Numeros.SumaIterativa(numero));
                        Console.ReadLine();
                        break;

                    case 5: //Suma Recursiva
                        Console.Clear();
                        Console.WriteLine("Hago la Suma Recursiva.");
                        Console.Write("Escriba un número: ");
                        numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("EL resultado es: {0}", Numeros.SumaRecursiva(numero));
                        Console.ReadLine();
                        break;

                    case 6: //Es Primo
                        Console.Clear();
                        Console.WriteLine("Compruebo si un número es primo o no.");
                        Console.Write("Escriba un número: ");
                        numero = int.Parse(Console.ReadLine());
                        if (Numeros.EsPrimo(numero))
                            Console.WriteLine("Es primo");
                        else
                            Console.WriteLine("No es primo");
                        Console.ReadLine();
                        break;
                    case 7:
                        salida = false;
                        break;
                } 
            } while (salida);
        }
    }
}
